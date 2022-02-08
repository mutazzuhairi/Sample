using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityViews
{
 
    public class UserView : BaseEntityView<long>
    {
         public string FirstName { get; set; }
         public string LastName { get; set; }
         public DateTime? DateOfBirth { get; set; }
         public DateTime? RegistrationDate { get; set; }
         public long BusinessId { get; set; }
         public virtual BusinessView Business { get; set; }
         public virtual ICollection<AbsenceView> AbsenceUser { get; set; }
         public virtual ICollection<AbsenceApprovalView> AbsenceApprovalUser { get; set; }
         public string UserName { get; set; }
         public string NormalizedUserName { get; set; }
         public string Email { get; set; }
         public string NormalizedEmail { get; set; }
         public bool EmailConfirmed { get; set; }
         public string PasswordHash { get; set; }
         public string SecurityStamp { get; set; }
         public string ConcurrencyStamp { get; set; }
         public string PhoneNumber { get; set; }
         public bool PhoneNumberConfirmed { get; set; }
         public bool TwoFactorEnabled { get; set; }
         public DateTimeOffset? LockoutEnd { get; set; }
         public bool LockoutEnabled { get; set; }
         public int AccessFailedCount { get; set; }

    }
}