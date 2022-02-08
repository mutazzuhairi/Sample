using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BLLayer.Extends.ExtendModels
{
    public class AbsenceDemoDTO
    {
        [Required]
        public long BusinessAbsenceTypeId { get; set; }
        [Required]
        public DateTime FromDate { get; set; }
        [Required]
        public DateTime ToDate { get; set; }
    }
}
