using Sample.BLLayer.EntityViews;

namespace Sample.BLLayer.Extends.ExtendModels
{
    public class AuthResponseModel
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }
        public UserView LoggedUser { get; set; }
    }
}
