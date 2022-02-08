using System;
using System.Data;
using System.Collections.Generic;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Sample.DataLayer.DataUtilities.DBContext;
using Sample.BLLayer.BLUtilities.HelperServices;
using Sample.DataLayer.DataUtilities.SystemConstants;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
using Hangfire;
using Hangfire.SqlServer;
using Newtonsoft.Json.Serialization;
using Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Configuration.Generated;
using Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Configuration;
using Hangfire.Dashboard;
using Hangfire.Dashboard.BasicAuthorization;

namespace Sample.Web.WebUtilities.Extensions
{
    public static class CommonExtensions
    {
        public static void UseSystemEndpoints(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";
            });
        }

        public static void AddUriToConfigure(this IServiceCollection services)
        {
            services.AddSingleton<IUriService>(o =>
            {
                var accessor = o.GetRequiredService<IHttpContextAccessor>();
                var request = accessor?.HttpContext?.Request;
                var uri = string.Concat(request?.Scheme, "://", request?.Host.ToUriComponent());
                return new UriService(uri);
            });

        }
        public static void AddCorsSecurity(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder
                        .WithOrigins(configuration.GetSection("AllowedCorsOrigins").Get<string[]>())
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });
        }
        public static void UseSwaggerInterface(this IApplicationBuilder app)
        {
            app.UseSwagger(c =>
            {
                c.RouteTemplate = SampleConstatnts.SwaggerProperites.SWAGGER_ROUTE_TEMPLATE;
            });
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint(SampleConstatnts.SwaggerProperites.SWAGGER_ROUTE,
                                 SampleConstatnts.SwaggerProperites.SWAGGER_NAME);
                c.RoutePrefix = SampleConstatnts.SwaggerProperites.SWAGGER_PATH;
            });

        }

        public static void UseHangfireInterface(this IApplicationBuilder app, IConfiguration configuration)
        {
            var hfOptions = new DashboardOptions
            {
                // Change `Back to site` link URL
                AppPath = configuration.GetValue<string>("FrontEndApp:BaseHref"),
                DashboardTitle = "Background Jobs Dashboard",
                Authorization = new IDashboardAuthorizationFilter[] {
                    new BasicAuthAuthorizationFilter(
                              new BasicAuthAuthorizationFilterOptions
                              {
                                  RequireSsl = false,
                                  SslRedirect = false,
                                  LoginCaseSensitive = true,
                                  Users = new[]
                                  {
                                      new BasicAuthAuthorizationUser
                                      {
                                          Login = "Sample",
                                          Password = new byte[] { 0x45,0x49,0x82,0xa2,0xfd,0xf6,0x86,0xa5,0x4d,0xe2,0xb2,0xf7,0x0a,0x05,0x6b,0x29,0xf4,0xfb,0x52,0xd4 }
                                      }
                                  }
                              })
                }
            };
            app.UseHangfireDashboard(configuration.GetValue<string>("Hangfire:BasePath", "WorkerRole"), hfOptions);
        }

        public static void AddSystemControllers(this IServiceCollection services)
        {
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
            services.AddControllers().AddNewtonsoftJson(options => 
            { 
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
        }

        public static void AddSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            var swaggerBasePath = configuration.GetValue<string>("Swagger:BasePath", "");

            services.AddSwaggerGen(c => {
                c.SwaggerDoc(SampleConstatnts.SwaggerProperites.SWAGGER_VERSION,
                                  new OpenApiInfo
                                  {
                                      Title = SampleConstatnts.SwaggerProperites.SWAGGER_TITLE,
                                      Version = SampleConstatnts.SwaggerProperites.SWAGGER_VERSION
                                  });

                c.AddSecurityDefinition("Sample.Web_Password", new OpenApiSecurityScheme()
                {
                    Name = "Bearer",
                    BearerFormat = "JWT",
                    Scheme = "bearer",
                    Description = "Specify the authorization token.",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows()
                    {
                        Password = new OpenApiOAuthFlow()
                        {
                            TokenUrl = new Uri($"{swaggerBasePath}/api/Authentication/Login", UriKind.Relative)
                        }
                    }
                });
            });
        }

        public static void AddHangfire(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHangfire(conf => {
                               conf
                              .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                              .UseSimpleAssemblyNameTypeSerializer()
                              .UseRecommendedSerializerSettings()
                              .UseSqlServerStorage(configuration.GetConnectionString(SampleConstatnts.ConnectionString.SAMPLE),
                              new SqlServerStorageOptions
                              {
                                  CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                                  SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                                  QueuePollInterval = TimeSpan.Zero,
                                  UseRecommendedIsolationLevel = true,
                                  DisableGlobalLocks = true
                              });
            });
            services.AddHangfireServer();
        }

        public static void AddLazierToConfigure(this IServiceCollection services)
        {
            services.AddScoped(typeof(Lazy<>), typeof(Lazier<>));
        }

        public static void AddDbContextToConfigure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MainContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(SampleConstatnts.ConnectionString.SAMPLE));
            });
        }

        public static void AddAutoMapperToConfigure(this IServiceCollection services)
        {
            services.AddAutoMapperConfiguration();
            services.AddCustomAutoMapperConfiguration();
        } 

        public static void AddDefaultIdentityOptions(this IServiceCollection services, IConfiguration configuration)
        {
            var identityConfig = configuration.GetSection("IdentityOptions");
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = identityConfig.GetValue<bool>("PasswordRequireDigit", true);
                options.Password.RequireLowercase = identityConfig.GetValue<bool>("PasswordRequireLowercase", true);
                options.Password.RequireNonAlphanumeric = identityConfig.GetValue<bool>("PasswordRequireNonAlphanumeric", true);
                options.Password.RequireUppercase = identityConfig.GetValue<bool>("PasswordRequireUppercase", true);
                options.Password.RequiredLength = identityConfig.GetValue<int>("PasswordRequiredLength", 12);
                options.Password.RequiredUniqueChars = identityConfig.GetValue<int>("PasswordRequiredUniqueChars", 1);
                options.User.RequireUniqueEmail = identityConfig.GetValue<bool>("UserRequireUniqueEmail", true);
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(identityConfig.GetValue<int>("LockoutTimeSpan", 5));
                options.Lockout.MaxFailedAccessAttempts = identityConfig.GetValue<int>("MaxFailedAccessAttempts", 5);
                options.SignIn.RequireConfirmedEmail = identityConfig.GetValue<bool>("SignInRequireConfirmedEmail", true);
            });
        }

        public static List<Dictionary<string, object>> ToJson(this DataTable dt)
        {
            var list = new List<Dictionary<string, object>>();

            foreach (DataRow row in dt.Rows)
            {
                var dict = new Dictionary<string, object>();

                foreach (DataColumn col in dt.Columns)
                {
                    if (row[col].ToString().StartsWith('{') || row[col].ToString().StartsWith('['))
                    {
                        dict[col.ColumnName] = JsonConvert.DeserializeObject(row[col].ToString());
                    }
                    else
                    {
                        dict[col.ColumnName] = row[col];
                    }
                }
                list.Add(dict);
            }

            return list;
        }


        internal class Lazier<T> : Lazy<T> where T : class
        {
            public Lazier(IServiceProvider provider)
                : base(() => provider.GetRequiredService<T>())
            {
            }
        }
    }
}
