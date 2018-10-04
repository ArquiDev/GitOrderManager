using OrderManager.AppManagers.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.AppManagers.Contracts
{
    public interface IOrderApplication
    {
        List<OrderDTO> GetList();
        List<OrderDTO> GetFilterBatch(FilterOrderDTO filter);
        long GetTotalOrders();
        void SaveCustomer(CustomerDTO customer);
    }
}
