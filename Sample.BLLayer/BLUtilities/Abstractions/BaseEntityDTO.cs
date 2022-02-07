using System;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Interfaces;

namespace Sample.BLLayer.BLUtilities.Abstractions
{
    public class BaseEntityDTO<TKey> : IBaseEntityDTO<TKey>
    {
        public virtual TKey Id { get; set; }
        [StringLength(500)]
        public virtual string Notes { get; set; }
        public virtual bool Void { get; set; }
        public virtual string VoidBy { get; set; }
        public virtual DateTimeOffset? VoidedDate { get; set; }
        public virtual string UpdatedBy { get; set; }
        public virtual DateTimeOffset UpdatedDate { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTimeOffset CreatedDate { get; set; }
        public virtual string SearchField { get; set; }
    }
}
