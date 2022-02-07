
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Sample.BLLayer.EntityDTOs
{
    public partial class UserTokenDTO
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        [StringLength(450)]
        public string LoginProvider { get; set; }
        [Required]
        [StringLength(450)]
        public string Name { get; set; }
        [ProtectedPersonalData]
        public string Value { get; set; }

    }
}