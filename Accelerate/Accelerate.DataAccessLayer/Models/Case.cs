using System;
using System.Collections.Generic;

#nullable disable

namespace Accelerate.DataAccessLayer.Models
{
    public partial class Case
    {
        public int CaseId { get; set; }
        public string CaseName { get; set; }
        public string Challenge { get; set; }
        public string Solution { get; set; }
        public string Comments { get; set; }

        public virtual DashBoard DashBoard { get; set; }
        public virtual ReportDatum ReportDatum { get; set; }
    }
}
