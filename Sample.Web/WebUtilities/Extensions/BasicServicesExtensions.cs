using Microsoft.Extensions.DependencyInjection;
using Sample.Web.WebUtilities.HelperServices;
using Sample.Web.WebUtilities.Interfaces;
using Sample.Web.WebUtilities.ExtendServices;

namespace Sample.Web.WebUtilities.Extensions
{
    public static class BasicServicesExtensions
    {

        public static void AddBasicServicesToConfigure(this IServiceCollection services)
        {
            services.AddScoped<IApiExceptionBuilder, ApiExceptionBuilder>();
            services.AddScoped<ITransactionFactory,  TransactionFactory>();
            services.AddScoped<IScheduleRecurringJobService, ScheduleRecurringJobService>();
        }
    }
}
