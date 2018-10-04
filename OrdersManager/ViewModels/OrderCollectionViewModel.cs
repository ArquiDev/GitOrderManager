using OrderManager.Model;
using OrderManager.UI.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.UI.ViewModels
{
    public class OrderCollectionViewModel
    {
        public const int BATCH_SIZE = 100_000;
        public FilterOrderViewModel Filter { get; set; }
        public long TotalOrders { get; set; }
        public List<Order> Orders { get; set; }
        public bool AreMore { get; set; }
        private int BacthNumer { get; set; }

        public OrderCollectionViewModel()
        {
            Orders = new List<Order>();
            Filter = new FilterOrderViewModel();
            TotalOrders = ManagerDataSource.Instance.GetTotalOrders();
        }
        public void NewSearch(FilterOrderViewModel filter)
        {
            this.Filter = filter;
            this.BacthNumer = 0;
            this.Orders.Clear();
        }
        public void GetNextBatch()
        {
            this.Filter.RowFrom = BATCH_SIZE * this.BacthNumer++;
            this.Filter.RowTo = BATCH_SIZE * this.BacthNumer;
            this.AreMore = this.Filter.RowTo < this.TotalOrders;
            var newOrders = ManagerDataSource.Instance.GetOrderFilter(this.Filter);
            this.Orders.AddRange(newOrders);
        }
    }
}
