using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityDTOs
{
 
    public class AbsenceTypeDTO : BaseEntityDTO<long>
    {
         [Key]
         public override long Id { get; set; }
         [Required]
         
         [StringLength(250)]
         public string Name { get; set; }
         public int? ValidAfterDays { get; set; }
         public virtual ICollection<BusinessAbsenceTypeDTO> BusinessAbsenceTypeAbsenceType { get; set; }
 
    }
}