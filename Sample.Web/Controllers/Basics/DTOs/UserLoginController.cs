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
 
    public class UserLoginController : CustomBaseController<UserLoginDTO, UserLoginView, IUserLoginUpdateService, IUserLoginQueryService, long>
    {
        private readonly Lazy<IUserLoginQueryService> _entityQueryService;
        private readonly Lazy<IUserLoginUpdateService> _entityUpdateService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<IApiExceptionBuilder> _apiExceptionBuilder;

        public UserLoginController(Lazy<IUserLoginQueryService> entityQueryService,
                                     Lazy<IUserLoginUpdateService> entityUpdateService,
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


