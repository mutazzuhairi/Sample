
using Sample.BLLayer.BLUtilities.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Sample.BLLayer.EntityDTOs
{
    public partial class RoleClaimDTO : BaseEntityDTO<int>
    {
        [Required]
        public long RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}