using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample.DataLayer.DataUtilities.Interfaces
{
    public interface IBaseEntity<TKey>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public TKey Id { get; set; }
        [StringLength(500)]
        [Column(Order = 900)]
        public string Notes { get; set; }
        [Required]
        [Column(Order = 901)]
        public bool Void { get; set; }
        [StringLength(255)]
        [Column(Order = 902)]
        public string VoidBy { get; set; }
        [Column(TypeName = "datetimeoffset(7)", Order = 903)]
        public DateTimeOffset? VoidedDate { get; set; }
        [Required]
        [StringLength(255)]
        [Column(Order = 904)]
        public string UpdatedBy { get; set; }
        [Required]
        [Column(TypeName = "datetimeoffset(7)", Order = 905)]
        public DateTimeOffset UpdatedDate { get; set; }
        [Required]
        [StringLength(255)]
        [Column(Order = 906)]
        public string CreatedBy { get; set; }
        [Required]
        [Column(TypeName = "datetimeoffset(7)", Order = 907)]
        public DateTimeOffset CreatedDate { get; set; }
        [Required]
        [Timestamp]
        [Column(Order = 908)]
        public byte[] Version { get; set; }
        [Column(Order = 909)]
        public string SearchField { get; set; }

    }
}
