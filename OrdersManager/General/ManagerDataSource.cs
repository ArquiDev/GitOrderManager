using OrderManager.AppManagers.Contracts;
using OrderManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using OrderManager.UI.ViewModels;
using OrderManager.AppManagers.DTO;

namespace OrderManager.UI.General
{
    public class ManagerDataSource
    {
        public IOrderApplication OrderManager { get; set; }
        private static ManagerDataSource instance;
        public static ManagerDataSource Instance => instance = instance ?? new ManagerDataSource();
        private ManagerDataSource()
        {
            OrderManager = IOC.Instance.Resolve<IOrderApplication>();
        }

        public List<Order> GetOrderFilter(FilterOrderViewModel filter) => OrderManager.GetFilterBatch(filter.Adapt<FilterOrderDTO>()).Adapt<List<Order>>();
        public long GetTotalOrders() => OrderManager.GetTotalOrders();
        public void SaveCustomer(Customer customer) => OrderManager.SaveCustomer(customer.Adapt<CustomerDTO>());

    }
}
