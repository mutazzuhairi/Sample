
namespace Sample.BLLayer.EntityViews
{
    public partial class UserLoginView
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public long UserId { get; set; }

    }
}