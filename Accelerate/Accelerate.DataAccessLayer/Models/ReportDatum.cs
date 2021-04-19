using System;
using System.Collections.Generic;

#nullable disable

namespace Accelerate.DataAccessLayer.Models
{
    public partial class ReportDatum
    {
        public int CaseId { get; set; }
        public string Increase1 { get; set; }
        public int? Increase11 { get; set; }
        public int? Increase1Base { get; set; }
        public string Increase2 { get; set; }
        public int? Increase21 { get; set; }
        public int? Increase2Base { get; set; }
        public string Decrease1 { get; set; }
        public int? Decrease11 { get; set; }
        public int? Decrease1Base { get; set; }
        public string Decrease2 { get; set; }
        public int? Decrease21 { get; set; }
        public int? Decrease2Base { get; set; }
        public int? Increase1After { get; set; }
        public int? Increase2After { get; set; }
        public int? Decrease1After { get; set; }
        public int? Decrease2After { get; set; }

        public virtual Case Case { get; set; }
    }
}
