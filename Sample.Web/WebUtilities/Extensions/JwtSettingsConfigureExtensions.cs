using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Sample.DataLayer.DataUtilities.SystemConstants;
using System;

namespace Sample.Web.WebUtilities.Extensions
{
    public static class JwtSettingsConfigureExtensions
    {
        public static void SetJwtSettingsConfigure(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection(SampleConstatnts.AppSettings.JWT_SETTINGS);
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
 
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["JwtSettings:Issuer"],
                    ValidAudience = configuration["JwtSettings:Issuer"],
                    ClockSkew = TimeSpan.FromSeconds(30)
                };
            });


        }
    }
}
