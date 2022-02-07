using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.Web.WebUtilities.Interfaces;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.UpdateServices.Interfaces;
using Sample.BLLayer.BLUtilities.HelperModels;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.DTOs
{

    public class UserController : CustomBaseController<UserDTO, UserView, IUserUpdateService, IUserQueryService, long>
    {

        private readonly Lazy<IUserQueryService> _entityQueryService;
        private readonly Lazy<IUserUpdateService> _entityUpdateService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<IApiExceptionBuilder> _apiExceptionBuilder;

        public UserController(Lazy<IUserQueryService> entityQueryService,
                              Lazy<IUserUpdateService> entityUpdateService,
                              Lazy<ISystemServiceProvider> systemServiceProvider,
                              Lazy<IApiExceptionBuilder> apiExceptionBuilder) :

            base(entityQueryService, entityUpdateService, systemServiceProvider, apiExceptionBuilder)
        {

            _entityUpdateService = entityUpdateService;
            _entityQueryService = entityQueryService;
            _systemServiceProvider = systemServiceProvider;
            _apiExceptionBuilder = apiExceptionBuilder;
        }


        //[HttpPut]
        //public override async Task<ActionResult<UserDTO>> Put(UserDTO userDTO)
        //{
        //    await _entityUpdateService.Value.CustomUpdateAsync(userDTO);
        //    return Ok(new Response<UserDTO>(userDTO));
        //}
 
    }
}