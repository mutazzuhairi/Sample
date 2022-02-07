using System;
using Sample.BLLayer.EntityDTOs;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.EntityViews;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.Views
{
 
    public class RoleClaimViewController : CustomBaseViewController<RoleClaimDTO, RoleClaimView, IRoleClaimQueryService>
    {

        private readonly Lazy<IRoleClaimQueryService> _entityQueryService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public RoleClaimViewController(Lazy<IRoleClaimQueryService> entityQueryService,
                                       Lazy<ISystemServiceProvider> systemServiceProvider) :
            base(entityQueryService, systemServiceProvider)
        {
        
          _entityQueryService = entityQueryService;
          _systemServiceProvider = systemServiceProvider;
        }


    }

}




