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
 
    public class UserTokenController : CustomBaseController<UserTokenDTO, UserTokenView, IUserTokenUpdateService, IUserTokenQueryService, long>
    {
        private readonly Lazy<IUserTokenQueryService> _entityQueryService;
        private readonly Lazy<IUserTokenUpdateService> _entityUpdateService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<IApiExceptionBuilder> _apiExceptionBuilder;

        public UserTokenController(Lazy<IUserTokenQueryService> entityQueryService,
                                     Lazy<IUserTokenUpdateService> entityUpdateService,
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


