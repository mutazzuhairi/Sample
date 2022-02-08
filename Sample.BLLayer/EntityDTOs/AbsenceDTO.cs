using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityDTOs
{
 
    public class AbsenceDTO : BaseEntityDTO<long>
    {
         [Key]
         public override long Id { get; set; }
         [Required]
         public long UserId { get; set; }
         [Required]
         public long BusinessAbsenceTypeId { get; set; }
         [Required]
         public DateTime FromDate { get; set; }
         [Required]
         public DateTime ToDate { get; set; }
         [Required]
         
         [StringLength(15)]
         public string Status { get; set; }
         public virtual UserDTO User { get; set; }
         public virtual BusinessAbsenceTypeDTO BusinessAbsenceType { get; set; }
         public virtual ICollection<AbsenceApprovalDTO> AbsenceApprovalAbsence { get; set; }
 
    }
}