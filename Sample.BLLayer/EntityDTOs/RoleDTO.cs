
using System.ComponentModel.DataAnnotations;

namespace Sample.BLLayer.EntityDTOs
{
    public partial class RoleDTO
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(256)]
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }
 
    }
}