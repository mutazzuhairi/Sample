using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityDTOs
{
 
    public class RoleDTO : BaseEntityDTO<long>
    {
         [Key]
         public override long Id { get; set; }
         [Required]
         [StringLength(256)]
         public string Name { get; set; }
         [StringLength(256)]
         public string NormalizedName { get; set; }
         public string ConcurrencyStamp { get; set; }
    }
}