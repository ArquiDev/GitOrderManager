using OrderManager.AppManagers.Contracts;
using OrderManager.AppManagers.DTO;
using OrderManager.Domain.Contracts.Services;
using OrderManager.Domain.DTOs;
using OrderManager.Domain.Entities;
using OrderManager.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.AppManagers.Services
{
    public class OrderApplication : IOrderApplication
    {
        private ICustomerService CustomerService { get; }
        private IOrderService OrderService { get; }

        public OrderApplication(ICustomerService customerService, IOrderService orderService)
        {
            this.CustomerService = customerService;
            this.OrderService = orderService;
        }


        public List<OrderDTO> GetList() => Util.Instance.Map<List<OrderDTO>>(OrderService.GetList());

        public long GetTotalOrders() => OrderService.GetTotalOrders();

        public List<OrderDTO> GetFilterBatch(FilterOrderDTO filter)
        {
            var domainFilter = Util.Instance.Map<FilterOrder>(filter);
            var orders = Util.Instance.Map<List<OrderDTO>>(OrderService.GetFilterBatch(domainFilter));
            var customers = Util.Instance.Map <List<CustomerDTO>>(CustomerService.GetFilterBatch(domainFilter));
            foreach(var order in orders.Where(o => o.CustomerId != Guid.Empty))
            {
                order.Customer = customers.FirstOrDefault(c => c.Id == order.CustomerId);
            }
            return orders;
        }
        public void SaveCustomer(CustomerDTO customer) => CustomerService.Update(Util.Instance.Map<Customer>(customer));
    }
}
