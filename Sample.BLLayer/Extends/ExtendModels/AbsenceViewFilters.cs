using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BLLayer.Extends.ExtendModels
{
    public class AbsenceViewFilters
    {
        public string AbsenceType { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Statues { get; set; }
        public DateTime? Created { get; set; }
    }
}
