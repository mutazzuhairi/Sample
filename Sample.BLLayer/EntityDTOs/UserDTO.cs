using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;
using System;

namespace Sample.BLLayer.EntityDTOs
{
    public partial class UserDTO  
    {
        [Required]
        [StringLength(200)]
        public string UserName { get; set; }
        [StringLength(256)]
        public string NormalizedUserName { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(256)]
        public string NormalizedEmail { get; set; }
        [Required]
        public bool EmailConfirmed { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public bool PhoneNumberConfirmed { get; set; }
        [Required]
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        [Required]
        public bool LockoutEnabled { get; set; }
        [Required]
        public int AccessFailedCount { get; set; }
    }
}
