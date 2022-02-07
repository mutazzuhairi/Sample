using Sample.BLLayer.EntityDTOs;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.EntityViews;
using Sample.BLLayer.QueryServices.Interfaces;
using System;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.Views
{
 
    public class RoleViewController : CustomBaseViewController<RoleDTO, RoleView, IRoleQueryService, long>
    {

        private readonly Lazy<IRoleQueryService> _entityQueryService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public RoleViewController(Lazy<IRoleQueryService> entityQueryService,
                                  Lazy<ISystemServiceProvider> systemServiceProvider) :
            base(entityQueryService, systemServiceProvider)
        {
        
            _entityQueryService = entityQueryService;
            _systemServiceProvider = systemServiceProvider;
        }


    }

}




