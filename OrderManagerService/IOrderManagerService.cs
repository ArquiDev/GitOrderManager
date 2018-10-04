using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.WebServices
{
    [ServiceContract]
    public interface IOrderManagerService
    {
        [OperationContract]
        int DoPlus(int a, int b);
    }
}
