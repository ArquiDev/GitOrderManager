using OrderManager.Domain.Contracts.Repositories;
using OrderManager.Domain.Entities;
using OrderManager.Data.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Domain.DTOs;

namespace OrderManager.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetList() =>
            DapperConnection.DoQuery<Customer>(CustomerQueries.GetList);

        public void Insert(Customer customer) =>
            DapperConnection.DoExecute(CustomerQueries.Insert, customer);
        public void Insert(IEnumerable<Customer> customers) =>
            DapperConnection.DoExecute(CustomerQueries.Insert, customers);

        public void Update(Customer customer) =>
            DapperConnection.DoExecute(CustomerQueries.Update, customer);
        public void Update(IEnumerable<Customer> customers) =>
            DapperConnection.DoExecute(CustomerQueries.Update, customers);

        public void Delete(Customer customer) =>
            DapperConnection.DoExecute(CustomerQueries.Delete, customer);
        public void Delete(IEnumerable<Customer> customers) =>
            DapperConnection.DoExecute(CustomerQueries.Delete, customers);


        public List<Customer> GetFilterBatch(FilterOrder filter)
        {
            var query = CustomerQueries.GetFilterBatch;
            var whereBuilder = new List<string>();
            if (filter != null)
            {
                if (filter.ValueFrom != null && filter.ValueFrom.Value > 0)
                    whereBuilder.Add($" o.OrderValue >= {filter.ValueFrom} ");
                if (filter.ValueTo != null && filter.ValueTo.Value > 0)
                    whereBuilder.Add($" o.OrderValue <= {filter.ValueTo} ");
                if (filter.DateFrom != null && filter.DateFrom.Value > OrderRepository.MIN_DATE)
                    whereBuilder.Add($" o.OrderDate >= '{filter.DateFrom.Value.ToString("yyyyMMdd")}' ");
                if (filter.DateTo != null && filter.DateTo.Value > OrderRepository.MIN_DATE)
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

                query = whereBuilder.Count > 0 ?
                            $" SELECT * FROM  ( {query} WHERE {String.Join(" AND ", whereBuilder)} ) AS QUERY WHERE QUERY.Id IS NOT NULL " :
                            $" SELECT * FROM  ( {query} ) AS QUERY WHERE QUERY.Id IS NOT NULL ";
            }
            if (filter.RowFrom != null || filter.RowTo != null)
            {
                whereBuilder.Clear();
                if (filter.RowFrom != null)
                    whereBuilder.Add($" rownumber >= {filter.RowFrom} ");
                if (filter.RowTo != null)
                    whereBuilder.Add($" rownumber <= {filter.RowTo} ");
                query = $" {query} AND {String.Join(" AND ", whereBuilder)} ";
            }
            return DapperConnection.DoQuery<Customer>(query);
        }
    }
}
