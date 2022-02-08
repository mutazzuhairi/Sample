using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityDTOs
{
 
    public class BusinessDTO : BaseEntityDTO<long>
    {
         [Key]
         public override long Id { get; set; }
         [Required]
         
         [StringLength(50)]
         public string Name { get; set; }
         public virtual ICollection<BusinessAbsenceTypeDTO> BusinessAbsenceTypeBusiness { get; set; }
         public virtual ICollection<UserDTO> UserBusiness { get; set; }
 
    }
}