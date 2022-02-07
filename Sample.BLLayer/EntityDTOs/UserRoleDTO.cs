
using System.ComponentModel.DataAnnotations;

namespace Sample.BLLayer.EntityDTOs
{
    public partial class UserRoleDTO
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        public long RoleId { get; set; }

    }
}