using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sample.DataLayer.DataUtilities.Abstractions;
using Sample.DataLayer.DataUtilities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Sample.DataLayer.Data.Models.Entities
{

    public class Absence : BaseEntity<long>
    {
         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Column(Order = 0)]
         public override long Id { get; set; }
         [Required]
         public long UserId { get; set; }
         [Required]
         public long BusinessAbsenceTypeId { get; set; }
         [Required]
         public DateTime FromDate { get; set; }
         [Required]
         public DateTime ToDate { get; set; }
         [Required]
         [Column(TypeName = "varchar")]
         [StringLength(15)]
         public string Status { get; set; }
         [ForeignKey(nameof(UserId))]
         [InverseProperty(nameof(Sample.DataLayer.Data.Models.Entities.User.AbsenceUser))]
         public virtual User User { get; set; }
         [ForeignKey(nameof(BusinessAbsenceTypeId))]
         [InverseProperty(nameof(Sample.DataLayer.Data.Models.Entities.BusinessAbsenceType.AbsenceBusinessAbsenceType))]
         public virtual BusinessAbsenceType BusinessAbsenceType { get; set; }
         [InverseProperty(nameof(AbsenceApproval.Absence))]
         public virtual ICollection<AbsenceApproval> AbsenceApprovalAbsence { get; set; }
    
    }
}