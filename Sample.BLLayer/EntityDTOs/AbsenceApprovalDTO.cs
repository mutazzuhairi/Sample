using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityDTOs
{
 
    public class AbsenceApprovalDTO : BaseEntityDTO<long>
    {
         [Key]
         public override long Id { get; set; }
         [Required]
         public long AbsenceId { get; set; }
         [Required]
         public bool Approved { get; set; }
         [Required]
         public long ManagerId { get; set; }
         public virtual AbsenceDTO Absence { get; set; }
         public virtual UserDTO User { get; set; }
 
    }
}