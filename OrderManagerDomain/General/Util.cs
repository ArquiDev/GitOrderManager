using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Domain.General
{
    public class Util
    {
        private static Util instance;
        public static Util Instance => instance = instance ?? new Util();
        private Util() { }

        public T Map<T>(Object obj) => obj.Adapt<T>();
    }
}
