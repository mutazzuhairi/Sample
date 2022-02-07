using System;
using System.ComponentModel.DataAnnotations;
using Sample.DataLayer.DataUtilities.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample.DataLayer.DataUtilities.Abstractions
{
    public abstract class  BaseEntity<TKey> : IBaseEntity<TKey>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public virtual TKey Id { get; set; }
        [StringLength(500)]
        [Column(Order = 900)]
        public virtual string Notes { get; set; }
        [Required]
        [Column(Order = 901)]
        public virtual bool Void { get; set; }
        [StringLength(255)]
        [Column(Order = 902)]
        public virtual string VoidBy { get; set; }
        [Column(TypeName = "datetimeoffset(7)", Order = 903)]
        public DateTimeOffset? VoidedDate { get; set; }
        [Required]
        [StringLength(255)]
        [Column(Order = 904)]
        public virtual string UpdatedBy { get; set; }
        [Required]
        [Column(TypeName = "datetimeoffset(7)", Order = 905)]
        public virtual DateTimeOffset UpdatedDate { get; set; }
        [Required]
        [StringLength(255)]
        [Column(Order = 906)]
        public virtual string CreatedBy { get; set; }
        [Required]
        [Column(TypeName = "datetimeoffset(7)", Order = 907)]
        public virtual DateTimeOffset CreatedDate { get; set; }
        [Required]
        [Timestamp]
        [Column(Order = 908)]
        public virtual byte[] Version { get; set; }
        [Column(Order = 909)]
        public virtual string SearchField { get; set; }

    }
}
