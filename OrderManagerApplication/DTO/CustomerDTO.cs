using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.AppManagers.DTO
{
    [DataContract]
    public class CustomerDTO
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public String FirstName { get; set; }
        [DataMember]
        public String LastName { get; set; }
    }
}
