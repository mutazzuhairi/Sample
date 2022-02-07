
using Sample.DataLayer.Data.Models.Entities;

namespace Sample.DataLayer.DataUtilities.HelperServices.Interfaces
{
    public interface ISystemServiceProvider
    {
        void SetCurrentUser(User user);
        User GetCurrentUser();
        long? GetCurrentUserId();
        string GetCurrentUserName();
    }
}
