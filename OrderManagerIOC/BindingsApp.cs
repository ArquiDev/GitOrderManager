using OrderManager.AppManagers.Contracts;
using OrderManager.AppManagers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.IOC
{
    public class BindingsApp
    {
        public void LoadApp(Bindings bindings)
        {
            bindings.Bind<IOrderApplication>().To<OrderApplication>();
        }
    }
}
