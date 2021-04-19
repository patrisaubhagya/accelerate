using System;
using System.Collections.Generic;

#nullable disable

namespace Accelerate.DataAccessLayer.Models
{
    public partial class DashBoard
    {
        public int CaseId { get; set; }
        public string SensitivityLevel { get; set; }
        public string Vertical { get; set; }
        public string Horizontal { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SearchWords { get; set; }

        public virtual Case Case { get; set; }
    }
}
