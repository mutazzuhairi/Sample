using System;
using Sample.BLLayer.EntityDTOs;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.EntityViews;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.Views
{
 
    public class UserClaimViewController : CustomBaseViewController<UserClaimDTO, UserClaimView, IUserClaimQueryService, int>
    {

        private readonly Lazy<IUserClaimQueryService> _entityQueryService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public UserClaimViewController(Lazy<IUserClaimQueryService> entityQueryService, 
                                       Lazy<ISystemServiceProvider> systemServiceProvider) :
            base(entityQueryService, systemServiceProvider)
        {
        
            _entityQueryService = entityQueryService;
            _systemServiceProvider = systemServiceProvider;
        }


    }

}




