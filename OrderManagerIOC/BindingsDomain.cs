using OrderManager.Domain.Contracts.Services;
using OrderManager.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.IOC
{
    public class BindingsDomain
    {
        public void LoadDomain(Bindings bindings)
        {
            bindings.Bind<IOrderService>().To<OrderService>();
            bindings.Bind<ICustomerService>().To<CustomerService>();
        }
    }
}
