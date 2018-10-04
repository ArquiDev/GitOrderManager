using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.AppManagers.DTO
{
    [DataContract()]
    public class OrderDTO
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public Guid CustomerId { get; set; }
        [DataMember]
        public String ReferenceNumber { get; set; }
        [DataMember]
        public Decimal OrderValue { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }

        [DataMember]
        public CustomerDTO Customer { get; set; }
    }
}
