using System;
using Sample.BLLayer.EntityDTOs;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.EntityViews;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.UpdateServices.Interfaces;
using Sample.Web.WebUtilities.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.DTOs
{
 
    public class UserClaimController : CustomBaseController<UserClaimDTO, UserClaimView, IUserClaimUpdateService, IUserClaimQueryService, int>
    {
        private readonly Lazy<IUserClaimQueryService> _entityQueryService;
        private readonly Lazy<IUserClaimUpdateService> _entityUpdateService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<IApiExceptionBuilder> _apiExceptionBuilder;

        public UserClaimController(Lazy<IUserClaimQueryService> entityQueryService,
                                     Lazy<IUserClaimUpdateService> entityUpdateService,
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


