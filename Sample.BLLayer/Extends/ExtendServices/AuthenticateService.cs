using System;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.Extends.ExtendModels;
using Sample.BLLayer.BLUtilities.SystemConstants;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;

namespace Sample.BLLayer.Extends.ExtendServices
{
    public class AuthenticateService : IAuthService
    {
        private readonly Lazy<IUserQueryService> _userQueryService;
        private readonly IConfigurationSection _jwtSettings;
        private readonly IMapper _mapper;
        private readonly Lazy<IServiceBuildException> _serviceBuildException;

        public AuthenticateService(Lazy<IUserQueryService> userQueryService,
                                   Lazy<IServiceBuildException>  serviceBuildException,
                                   IConfiguration configuration,
                                   IMapper mapper)

        {
            _userQueryService = userQueryService;
            _jwtSettings = configuration.GetSection(BLLayerConstatnts.AppSettings.JWT_SETTINGS);
            _serviceBuildException = serviceBuildException;
            _mapper = mapper;
        }

        public async Task<AuthResponseModel> Login(UserAuthModel userAuthModel)
        {
            var user = await _userQueryService.Value.FindByEmailAsync(userAuthModel.UserName);
            if (user == null || !await CheckUserPassword(user, userAuthModel.Password))
                return null;
            var loggedUser = this._mapper.Map<UserView>(user);
            var token = GenerateJwtToken(user.Id, user.UserName);
            return new AuthResponseModel { IsAuthSuccessful = true, Token = token, LoggedUser = loggedUser };

        }


        private string GenerateJwtToken(long userId, string userName)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                    new Claim(ClaimTypes.Name, userName.ToString())
                }),
                Expires = DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSettings.GetSection(BLLayerConstatnts.AppSettings.EXPIRY_IN_MINUTEW).Value)),
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


        private async Task<bool> CheckUserPassword(User user, string password)
        {
            return await _userQueryService.Value.CheckPasswordAsync(user, password);
        }
    }
}
