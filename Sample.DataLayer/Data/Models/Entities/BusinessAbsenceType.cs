using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sample.DataLayer.DataUtilities.Abstractions;
using Sample.DataLayer.DataUtilities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Sample.DataLayer.Data.Models.Entities
{

    public class BusinessAbsenceType : BaseEntity<long>
    {
         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Column(Order = 0)]
         public override long Id { get; set; }
         [Required]
         public long BusinessId { get; set; }
         [Required]
         public long AbsenceTypeId { get; set; }
         [ForeignKey(nameof(BusinessId))]
         [InverseProperty(nameof(Sample.DataLayer.Data.Models.Entities.Business.BusinessAbsenceTypeBusiness))]
         public virtual Business Business { get; set; }
         [ForeignKey(nameof(AbsenceTypeId))]
         [InverseProperty(nameof(Sample.DataLayer.Data.Models.Entities.AbsenceType.BusinessAbsenceTypeAbsenceType))]
         public virtual AbsenceType AbsenceType { get; set; }
         [InverseProperty(nameof(Absence.BusinessAbsenceType))]
         public virtual ICollection<Absence> AbsenceBusinessAbsenceType { get; set; }
    
    }
}