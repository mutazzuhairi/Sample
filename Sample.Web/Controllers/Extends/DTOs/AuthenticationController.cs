
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Sample.BLLayer.Extends.ExtendModels;
using AutoMapper;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;
using Sample.BLLayer.BLUtilities.HelperModels;
using Sample.BLLayer.UpdateServices.Interfaces;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Extends.DTOs
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly Lazy<IAuthService> _authService;
        private readonly Lazy<IUserUpdateService> _userUpdateService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly IMapper _mapper;

        public AuthenticationController(Lazy<IAuthService> authService,
                                        Lazy<IUserUpdateService> userUpdateService,
                                        Lazy<ISystemServiceProvider> systemServiceProvider,
                                        IMapper mapper)
        {
            _authService = authService;
            _userUpdateService = userUpdateService;
            _systemServiceProvider = systemServiceProvider;
            _mapper = mapper;
        }


        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<ActionResult<AuthResponseModel>> Login([FromForm] UserAuthModel userAuthModel)
        {
 
            AuthResponseModel authResult = await _authService.Value.Login(userAuthModel);
            if (authResult == null)
                return Unauthorized(new AuthResponseModel { ErrorMessage = "Invalid Authentication" });
            return Ok(new Response<AuthResponseModel>(authResult));
 
        }

        [HttpPost("SignUp")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDTO>> PostSignUp(SignUpUserModel signUpUserModel)
        {
 
            UserDTO userDTO = this._mapper.Map<UserDTO>(signUpUserModel);
            await _userUpdateService.Value.CustomCreateAsync(userDTO, signUpUserModel.Password);
            return Ok(new Response<UserDTO>(userDTO));
 
        }
 

        [HttpPut("EnableUser/{email}")]
        public async Task<ActionResult<UserDTO>> PutEnableUser(string userId)
        { 
            await _userUpdateService.Value.SetLockoutEnabledAsync(userId, true);
            return Ok();
 
        }
    }
}
