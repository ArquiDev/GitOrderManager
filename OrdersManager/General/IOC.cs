using Ninject;
using OrderManager.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.UI.General
{
    public class IOC
    {
        private static IOC instance;
        public static IOC Instance => instance = instance ?? new IOC();
        private IOC() { }

        private IKernel kernel;
        public IKernel Kernel => kernel = kernel ?? GetKernel();
        private IKernel GetKernel()
        {
            var kernelImplement = new StandardKernel();
            kernelImplement.Load(new Bindings());
            return kernelImplement;
        }

        public T Resolve<T>() => Kernel.Get<T>();

    }
}
