using OrderManager.Domain.Contracts.Base;
using OrderManager.Domain.DTOs;
using OrderManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Domain.Contracts.Repositories
{
    public interface IOrderRepository : IEdit<Order>
    {
        List<Order> GetFilterBatch(FilterOrder filter);
        long GetTotalOrders();
    }
}
