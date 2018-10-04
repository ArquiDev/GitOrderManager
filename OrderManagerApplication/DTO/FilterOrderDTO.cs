using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.AppManagers.DTO
{
    [DataContract]
    public class FilterOrderDTO
    {
        [DataMember]
        public int? RowFrom { get; set; }
        [DataMember]
        public int? RowTo { get; set; }
        [DataMember]
        public Decimal? ValueFrom { get; set; }
        [DataMember]
        public Decimal? ValueTo { get; set; }
        [DataMember]
        public DateTime? DateFrom { get; set; }
        [DataMember]
        public DateTime? DateTo { get; set; }
        [DataMember]
        public string Text { get; set; }
    }
}
