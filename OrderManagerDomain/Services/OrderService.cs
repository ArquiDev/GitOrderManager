using OrderManager.Domain.Contracts.Repositories;
using OrderManager.Domain.Contracts.Services;
using OrderManager.Domain.DTOs;
using OrderManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Domain.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository OrderRepository { get; }

        public OrderService(IOrderRepository orderRepository) => this.OrderRepository = orderRepository;


        public List<Order> GetList() => OrderRepository.GetList();

        public long GetTotalOrders() => OrderRepository.GetTotalOrders();


        public void Insert(Order order) => OrderRepository.Insert(order);
        public void Insert(IEnumerable<Order> orders) => OrderRepository.Insert(orders);

        public void Update(Order order) => OrderRepository.Update(order);
        public void Update(IEnumerable<Order> orders) => OrderRepository.Update(orders);

        public void Delete(Order order) => OrderRepository.Delete(order);
        public void Delete(IEnumerable<Order> orders) => OrderRepository.Delete(orders);

        public List<Order> GetFilterBatch(FilterOrder filter) => OrderRepository.GetFilterBatch(filter);

    }
}
