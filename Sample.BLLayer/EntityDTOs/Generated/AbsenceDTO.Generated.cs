//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Sample Team Tools.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityDTOs
{
 
    public partial class AbsenceDTO : BaseEntityDTO<long>
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