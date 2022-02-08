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
 
    public partial class BusinessDTO : BaseEntityDTO<long>
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