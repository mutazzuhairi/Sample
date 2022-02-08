using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sample.DataLayer.DataUtilities.Abstractions;
using Sample.DataLayer.DataUtilities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Sample.DataLayer.Data.Models.Entities
{

    public partial class User : IBaseEntity<long>
    {
         [Required]
         [Column(TypeName = "varchar")]
         [StringLength(100)]
         public string FirstName { get; set; }
         [Required]
         [Column(TypeName = "varchar")]
         [StringLength(100)]
         public string LastName { get; set; }
         public DateTime? DateOfBirth { get; set; }
         public DateTime? RegistrationDate { get; set; }
         [Required]
         public long BusinessId { get; set; }
         [ForeignKey(nameof(BusinessId))]
         [InverseProperty(nameof(Sample.DataLayer.Data.Models.Entities.Business.UserBusiness))]
         public virtual Business Business { get; set; }
         [InverseProperty(nameof(Absence.User))]
         public virtual ICollection<Absence> AbsenceUser { get; set; }
         [InverseProperty(nameof(AbsenceApproval.User))]
         public virtual ICollection<AbsenceApproval> AbsenceApprovalUser { get; set; }
    
    }
}