using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sample.DataLayer.DataUtilities.Abstractions;
using Sample.DataLayer.DataUtilities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Sample.DataLayer.Data.Models.Entities
{

    public class AbsenceType : BaseEntity<long>
    {
         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Column(Order = 0)]
         public override long Id { get; set; }
         [Required]
         [Column(TypeName = "varchar")]
         [StringLength(250)]
         public string Name { get; set; }
         public int? ValidAfterDays { get; set; }
         [InverseProperty(nameof(BusinessAbsenceType.AbsenceType))]
         public virtual ICollection<BusinessAbsenceType> BusinessAbsenceTypeAbsenceType { get; set; }
    
    }
}