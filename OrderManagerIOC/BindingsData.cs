using OrderManager.Data.Repositories;
using OrderManager.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.IOC
{
    public class BindingsData
    {
        public void LoadData(Bindings bindings)
        {
            bindings.Bind<IOrderRepository>().To<OrderRepository>();
            bindings.Bind<ICustomerRepository>().To<CustomerRepository>();
        }
    }
}
