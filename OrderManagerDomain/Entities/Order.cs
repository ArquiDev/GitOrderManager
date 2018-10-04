using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public String ReferenceNumber { get; set; }
        public Decimal OrderValue { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
