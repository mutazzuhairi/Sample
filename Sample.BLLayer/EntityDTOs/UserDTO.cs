using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityDTOs
{
 
    public class UserDTO : BaseEntityDTO<long>
    {
        [Key]
        public override long Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? RegistrationDate { get; set; }
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
        [Required]
        public long BusinessId { get; set; }
        public virtual BusinessDTO Business { get; set; }
        public virtual ICollection<AbsenceDTO> AbsenceUser { get; set; }
        public virtual ICollection<AbsenceApprovalDTO> AbsenceApprovalUser { get; set; }

 
    }
}