using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityDTOs
{
 
    public class BusinessAbsenceTypeDTO : BaseEntityDTO<long>
    {
         [Key]
         public override long Id { get; set; }
         [Required]
         public long BusinessId { get; set; }
         [Required]
         public long AbsenceTypeId { get; set; }
         public virtual BusinessDTO Business { get; set; }
         public virtual AbsenceTypeDTO AbsenceType { get; set; }
         public virtual ICollection<AbsenceDTO> AbsenceBusinessAbsenceType { get; set; }
 
    }
}