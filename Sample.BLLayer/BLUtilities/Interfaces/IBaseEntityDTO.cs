using System;
using System.ComponentModel.DataAnnotations;

namespace Sample.BLLayer.BLUtilities.Interfaces
{
    public interface IBaseEntityDTO<TKey>
    {
        public TKey Id { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public bool Void { get; set; }
        public string VoidBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTimeOffset? VoidedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string SearchField { get; set; }
    }
}
