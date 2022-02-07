using System;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.Web.WebUtilities.Interfaces;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.UpdateServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.DTOs
{
 
    public class RoleClaimController : CustomBaseController<RoleClaimDTO, RoleClaimView, IRoleClaimUpdateService, IRoleClaimQueryService, int>
    {
        private readonly Lazy<IRoleClaimQueryService> _entityQueryService;
        private readonly Lazy<IRoleClaimUpdateService> _entityUpdateService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<IApiExceptionBuilder> _apiExceptionBuilder;

        public RoleClaimController(Lazy<IRoleClaimQueryService> entityQueryService,
                                     Lazy<IRoleClaimUpdateService> entityUpdateService,
                                     Lazy<ISystemServiceProvider> systemServiceProvider,
                                     Lazy<IApiExceptionBuilder> apiExceptionBuilder) :
            base(entityQueryService, entityUpdateService, systemServiceProvider, apiExceptionBuilder)
        {

           _entityQueryService = entityQueryService;
           _entityUpdateService = entityUpdateService;
           _systemServiceProvider = systemServiceProvider;
           _apiExceptionBuilder = apiExceptionBuilder;

        }


    }

}


