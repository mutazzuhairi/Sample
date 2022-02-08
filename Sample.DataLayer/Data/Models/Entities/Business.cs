using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sample.DataLayer.DataUtilities.Abstractions;
using Sample.DataLayer.DataUtilities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Sample.DataLayer.Data.Models.Entities
{

    public class Business : BaseEntity<long>
    {
         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Column(Order = 0)]
         public override long Id { get; set; }
         [Required]
         [Column(TypeName = "varchar")]
         [StringLength(50)]
         public string Name { get; set; }
         [InverseProperty(nameof(BusinessAbsenceType.Business))]
         public virtual ICollection<BusinessAbsenceType> BusinessAbsenceTypeBusiness { get; set; }
         [InverseProperty(nameof(User.Business))]
         public virtual ICollection<User> UserBusiness { get; set; }
    
    }
}