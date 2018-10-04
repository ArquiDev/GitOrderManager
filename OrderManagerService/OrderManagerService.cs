using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.WebServices
{
    public class OrderManagerService : IOrderManagerService
    {
        public int DoPlus(int a, int b)
        {
            return a + b;
        }
    }
}
