using Microsoft.Extensions.DependencyInjection;
using Sample.BLLayer.Extends.ExtendServices;
using Sample.BLLayer.BLUtilities.HelperServices;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
 
namespace Sample.BLLayer.BLUtilities.Extensions
{
    public static class CommonExtensions
    {
        public static void AddCommonServicesToConfigure(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthenticateService>();
            services.AddScoped<IServiceBuildException, ServiceBuildException>();
            services.AddScoped<IPaginationHelper, PaginationHelper>();
            services.AddScoped<ICommonServices, CommonServices>();
            services.AddScoped<ICacheProvider, CacheProvider>();
            services.AddScoped<IMailService, MailService>();
        }

    }
}
