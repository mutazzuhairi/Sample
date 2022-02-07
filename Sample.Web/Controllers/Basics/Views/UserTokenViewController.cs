using System;
using Sample.BLLayer.EntityDTOs;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.EntityViews;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.Views
{
 
    public class UserTokenViewController : CustomBaseViewController<UserTokenDTO, UserTokenView, IUserTokenQueryService>
    {

        private readonly Lazy<IUserTokenQueryService> _entityQueryService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public UserTokenViewController(Lazy<IUserTokenQueryService> entityQueryService,
                                       Lazy<ISystemServiceProvider> systemServiceProvider) :
            base(entityQueryService, systemServiceProvider)
        {
        
            _entityQueryService = entityQueryService;
            _systemServiceProvider = systemServiceProvider;
        }


    }

}




