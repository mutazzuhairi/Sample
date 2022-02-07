using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Sample.DataLayer.DataUtilities.Interfaces;

namespace Sample.DataLayer.Data.Models.Entities
{
    public partial class UserToken : IdentityUserToken<long>, IBaseEntity<long>
    {
        [Key]
        [Column(Order = 0)]
        public long Id { get; set; }
        [Required]
        [Column(Order = 1)]
        public override long UserId { get; set; }
        [Required]
        [StringLength(450)]
        [Column(Order = 2)]
        public override string LoginProvider { get; set; }
        [Required]
        [StringLength(450)]
        [Column(Order = 3)]
        public override string Name { get; set; }
        [ProtectedPersonalData]
        [Column(Order = 4)]
        public override string Value { get; set; }
        [StringLength(500)]
        [Column(Order = 900)]
        public string Notes { get; set; }
        [Required]
        [Column(Order = 901)]
        public bool Void { get; set; }
        [Required]
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
