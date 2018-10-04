using Dapper;
using OrderManager.Domain.Contracts.Repositories;
using OrderManager.Domain.Entities;
using OrderManager.Data.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Domain.DTOs;

namespace OrderManager.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public static DateTime MIN_DATE = new DateTime(2000, 1, 1);

        public List<Order> GetList() => 
            DapperConnection.DoQuery<Order>(OrderQueries.GetList);

        public long GetTotalOrders() =>
            DapperConnection.DoQuery<long>(OrderQueries.GetTotalOrders).First();

        public void Insert(Order order) =>
            DapperConnection.DoExecute(OrderQueries.Insert, order);
        public void Insert(IEnumerable<Order> orders) =>
            DapperConnection.DoExecute(OrderQueries.Insert, orders);

        public void Update(Order order) =>
            DapperConnection.DoExecute(OrderQueries.Update, order);
        public void Update(IEnumerable<Order> orders) =>
            DapperConnection.DoExecute(OrderQueries.Update, orders);

        public void Delete(Order order) =>
            DapperConnection.DoExecute(OrderQueries.Delete, order);
        public void Delete(IEnumerable<Order> orders) =>
            DapperConnection.DoExecute(OrderQueries.Delete, orders);

        public List<Order> GetFilterBatch(FilterOrder filter)
        {
            var query = OrderQueries.GetFilterBatch;
            var whereBuilder = new List<string>();
            if(filter != null)
            {
                if (filter.ValueFrom != null && filter.ValueFrom.Value > 0)
                    whereBuilder.Add($" o.OrderValue >= {filter.ValueFrom} ");
                if (filter.ValueTo != null && filter.ValueTo.Value > 0)
                    whereBuilder.Add($" o.OrderValue <= {filter.ValueTo} ");
                if (filter.DateFrom != null && filter.DateFrom.Value > MIN_DATE)
                    whereBuilder.Add($" o.OrderDate >= '{filter.DateFrom.Value.ToString("yyyyMMdd")}' ");
                if (filter.DateTo != null && filter.DateTo.Value > MIN_DATE)
                    whereBuilder.Add($" o.OrderDate >= '{filter.DateTo.Value.ToString("yyyyMMdd")}' ");
                if (!String.IsNullOrWhiteSpace(filter.Text))
                {
                    var whereText = new List<string>();
                    foreach (var word in filter.Text.Split(' ').Where(w => w.Length > 2))
                    {
                        whereText.Add($" o.ReferenceNumber LIKE '%{word}%' ");
                        whereText.Add($" c.FirstName LIKE '%{word}%' ");
                        whereText.Add($" c.LastName LIKE '%{word}%' ");
                    }
                    whereBuilder.Add($" ({String.Join(" OR ", whereText)}) ");
                }
                if (whereBuilder.Count > 0)
                    query = $" {query} WHERE {String.Join(" AND ", whereBuilder)} ";
            }
            if(filter.RowFrom != null || filter.RowTo != null)
            {
                whereBuilder.Clear();
                if (filter.RowFrom != null)
                    whereBuilder.Add($" rownumber >= {filter.RowFrom} ");
                if (filter.RowTo != null)
                    whereBuilder.Add($" rownumber <= {filter.RowTo} ");
                query = $" SELECT * FROM  ( {query} ) AS QUERY WHERE {String.Join(" AND ", whereBuilder)} "; 
            }
            return DapperConnection.DoQuery<Order>(query);
        }

    }
}
