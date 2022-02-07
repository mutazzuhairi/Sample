
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.DataLayer.DataUtilities.HelperServices
{
    public class SystemServiceProvider : ISystemServiceProvider
    {
        private User CurrentUser = null;

        public User GetCurrentUser()
        {
            return CurrentUser;
        }

        public long? GetCurrentUserId()
        {
            return CurrentUser?.Id;
        }

        public void SetCurrentUser(User user)
        {

            if (CurrentUser == null)
            {
                CurrentUser = user;
            }
        }

        public string GetCurrentUserName()
        {
            return CurrentUser?.UserName;
        }

    }
}
