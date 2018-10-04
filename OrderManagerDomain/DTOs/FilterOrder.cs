using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Domain.DTOs
{
    public class FilterOrder
    {
        public int? RowFrom { get; set; }
        public int? RowTo { get; set; }
        public Decimal? ValueFrom { get; set; }
        public Decimal? ValueTo { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Text { get; set; }
    }
}
