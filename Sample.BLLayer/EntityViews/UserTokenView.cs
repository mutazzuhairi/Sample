
namespace Sample.BLLayer.EntityViews
{
    public partial class UserTokenView
    {
        public long UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

    }
}