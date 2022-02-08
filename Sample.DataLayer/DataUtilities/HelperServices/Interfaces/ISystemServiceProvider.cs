

namespace Sample.DataLayer.DataUtilities.HelperServices.Interfaces
{
    public interface ISystemServiceProvider
    {
        long? GetCurrentUserId();
        string GetCurrentUserName();
    }
}
