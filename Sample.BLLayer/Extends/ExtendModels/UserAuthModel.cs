using System.ComponentModel.DataAnnotations;
 

namespace Sample.BLLayer.Extends.ExtendModels
{
    public class UserAuthModel
    {
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}
