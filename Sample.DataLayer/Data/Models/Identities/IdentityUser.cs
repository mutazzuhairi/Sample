using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Sample.DataLayer.DataUtilities.Interfaces;

namespace Sample.DataLayer.Data.Models.Entities
{
    public partial class User : IdentityUser<long>, IBaseEntity<long>
    {
        [Key]
        [PersonalData]
        [Column(Order = 0)]
        public override long Id { get; set; }
        [Required]
        [StringLength(200)]
        [ProtectedPersonalData]
        [Column(Order = 1)]
        public override string UserName { get; set; }
        [StringLength(256)]
        [Column(Order = 2)]
        public override string NormalizedUserName { get; set; }
        [Required]
        [StringLength(100)]
        [ProtectedPersonalData]
        [Column(Order = 3)]
        public override string Email { get; set; }
        [StringLength(256)]
        [Column(Order = 4)]
        public override string NormalizedEmail { get; set; }
        [Required]
        [PersonalData]
        [Column(Order = 5)]
        public override bool EmailConfirmed { get; set; }
        [Required]
        [Column(Order = 6)]
        public override string PasswordHash { get; set; }
        [Column(Order = 7)]
        public override string SecurityStamp { get; set; }
        [Column(Order = 8)]
        public override string ConcurrencyStamp { get; set; }
        [ProtectedPersonalData]
        [Column(Order = 9)]
        public override string PhoneNumber { get; set; }
        [Required]
        [PersonalData]
        [Column(Order = 10)]
        public override bool PhoneNumberConfirmed { get; set; }
        [Required]
        [PersonalData]
        [Column(Order = 12)]
        public override bool TwoFactorEnabled { get; set; }
        [Column(TypeName = "datetimeoffset(7)", Order = 13)]
        public override DateTimeOffset? LockoutEnd { get; set; }
        [Required]
        [Column(Order = 14)]
        public override bool LockoutEnabled { get; set; }
        [Required]
        [Column(Order = 15)]
        public override int AccessFailedCount { get; set; }
        [StringLength(500)]
        [Column(Order = 900)]
        public string Notes { get; set; }
        [Required]
        [Column(Order = 901)]
        public bool Void { get; set; }
        [StringLength(256)]
        [Column(Order = 902)]
        public string VoidBy { get; set; }
        [Column(TypeName = "datetimeoffset(0)", Order = 903)]
        public DateTimeOffset? VoidedDate { get; set; }
        [Required]
        [StringLength(256)]
        [Column(Order = 904)]
        public string UpdatedBy { get; set; }
        [Required]
        [Column(TypeName = "datetimeoffset(0)", Order = 905)]
        public DateTimeOffset UpdatedDate { get; set; }
        [Required]
        [StringLength(256)]
        [Column(Order = 906)]
        public string CreatedBy { get; set; }
        [Required]
        [Column(TypeName = "datetimeoffset(0)", Order = 907)]
        public DateTimeOffset CreatedDate { get; set; }
        [Required]
        [Timestamp]
        [Column(Order = 908)]
        public byte[] Version { get; set; }
        [Column(Order = 909)]
        public string SearchField { get; set; }
    }
}
