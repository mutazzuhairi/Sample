
using System.ComponentModel.DataAnnotations;

namespace Sample.BLLayer.EntityDTOs
{
    public partial class UserLoginDTO
    {
        [Required]
        [StringLength(450)]
        public string LoginProvider { get; set; }
        [Required]
        [StringLength(450)]
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        [Required]
        public long UserId { get; set; }

    }
}