using Sample.BLLayer.BLUtilities.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sample.Web.WebUtilities.Extensions;
using Sample.Web.WebUtilities.Middlewares;
using Sample.DataLayer.DataUtilities.Extensions;
using Sample.Web.WebUtilities.Interfaces;

namespace Sample.Web
{
    public class Startup
    {
 
        public Startup(IConfiguration configuration)
        {
             Configuration = configuration;
        }
         
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddMemoryCache();
            services.AddDbContextToConfigure(Configuration);
            services.AddHttpContextAccessor();
            services.AddUriToConfigure();
            services.AddAutoMapperToConfigure();
            services.AddCorsSecurity(Configuration);
            services.AddDefaultIdentityOptions(Configuration);
            services.SetJwtSettingsConfigure(Configuration);
            services.AddSwagger(Configuration);
            //services.AddHangfire(Configuration);
            services.AddBasicServicesToConfigure();
            services.AddEntityServicesToConfigure();
            services.AddDataServicesToConfigure();
            services.AddCommonServicesToConfigure();
            services.AddSystemControllers();
            services.AddLazierToConfigure();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IScheduleRecurringJobService recurringJob)
        {
            app.UseStaticFiles();
            app.UseRouting();
            app.UseActivityLoggingMiddleware();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseSpaStaticFiles();
            }
            app.UseSwaggerInterface();
            app.UseCors();
            //app.UseHangfireInterface(Configuration);
            //recurringJob.AddScheduleRecurringJobS();
            app.UseErrorHandlingMiddleware();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseAdminSafeListMiddleware();
            app.UseSystemEndpoints(env);
        }
 
    }
}
