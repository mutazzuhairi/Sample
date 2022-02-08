using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sample.DataLayer.DataUtilities.Abstractions;
using Sample.DataLayer.DataUtilities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Sample.DataLayer.Data.Models.Entities
{

    public class AbsenceApproval : BaseEntity<long>
    {
         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Column(Order = 0)]
         public override long Id { get; set; }
         [Required]
         public long AbsenceId { get; set; }
         [Required]
         public bool Approved { get; set; }
         [Required]
         public long ManagerId { get; set; }
         [ForeignKey(nameof(AbsenceId))]
         [InverseProperty(nameof(Sample.DataLayer.Data.Models.Entities.Absence.AbsenceApprovalAbsence))]
         public virtual Absence Absence { get; set; }
         [ForeignKey(nameof(ManagerId))]
         [InverseProperty(nameof(Sample.DataLayer.Data.Models.Entities.User.AbsenceApprovalUser))]
         public virtual User User { get; set; }
    
    }
}