using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.IOC
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            (new BindingsApp()).LoadApp(this);
            (new BindingsDomain()).LoadDomain(this);
            (new BindingsData()).LoadData(this);
        }
    }
}
