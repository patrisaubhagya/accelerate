using System;
using System.Collections.Generic;

#nullable disable

namespace Accelerate.DataAccessLayer.Models
{
    public partial class ContactDetail
    {
        public int? CaseId { get; set; }
        public string Client { get; set; }
        public decimal? DeliveryManager { get; set; }
        public string DeliveryManagerId { get; set; }
        public string DeliveryAnchor { get; set; }
        public string OfferingHead { get; set; }

        public virtual Case Case { get; set; }
    }
}
