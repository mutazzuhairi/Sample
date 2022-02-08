using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityDTOs
{
 
    public class UserRoleDTO : BaseEntityDTO<long>
    {
        [Key]
        public override long Id { get; set; }
        [Required]
        public long UserId { get; set; }
        [Required]
        public long RoleId { get; set; }
    }
}