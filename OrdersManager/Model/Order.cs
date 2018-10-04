using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Model
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public String ReferenceNumber { get; set; }
        public Decimal OrderValue { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }

        public String CustomerName => $"{Customer?.FirstName} {Customer?.LastName}";
    }
}
