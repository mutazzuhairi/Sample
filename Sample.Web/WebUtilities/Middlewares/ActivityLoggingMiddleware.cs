using Sample.BLLayer.BLUtilities.HelperServices;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Sample.Web.WebUtilities.Middlewares
{
    public class ActivityLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public ActivityLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext,
                                      ISystemServiceProvider systemServiceProvider,
                                      ILogger<ActivityLoggingMiddleware> logger)
        {
            var sw = Stopwatch.StartNew();
            httpContext.Request.EnableBuffering();
            var body = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();
            httpContext.Request.Body.Seek(0, SeekOrigin.Begin);

            Dictionary<string, object> dictionary = new Dictionary<string, object>();

            try
            {
                await _next(httpContext);
            }
            catch (AppException ex)
            {
                
                if (null != ex.validationProblemDetails)
                {
                    dictionary.Add("Title", ex.validationProblemDetails.Title);
                    dictionary.Add("Errors", ex.Message);
                }
                else if (null != ex.problemDetails)
                {
                    dictionary.Add("Title", ex.problemDetails.Title);
                    dictionary.Add("Detail", ex.problemDetails.Detail);
                }
                else
                {
                    dictionary.Add(ex.PropertyName, ex.Message);
                }
            }
            catch (Exception ex)
            {
                dictionary.Add("Message", ex.Message);
                dictionary.Add("InnerException", ex.InnerException);
                dictionary.Add("StackTrace", ex.StackTrace);
            }
            finally
            {
                sw.Stop();
                double elapsed = sw.Elapsed.TotalMilliseconds;
                MappedDiagnosticsLogicalContext.Set("userIdentityId", httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "N/A");
                MappedDiagnosticsLogicalContext.Set("userIdentityUsername", httpContext.User.FindFirstValue(ClaimTypes.Name) ?? "N/A");
                MappedDiagnosticsLogicalContext.Set("responseStatusCode", httpContext.Response.StatusCode.ToString() ?? "N/A");

                var message = JsonConvert.SerializeObject(new {
                    ExecutionTime = elapsed,
                    RequestBody = body,
                    Details = dictionary
                });
                
                switch (httpContext.Response.StatusCode)
                {
                    case (int)HttpStatusCode.BadRequest:
                    case (int)HttpStatusCode.Forbidden:
                        logger.LogWarning(message);
                        break;
                    case (int)HttpStatusCode.Unauthorized:
                        logger.LogWarning(message);
                        break;
                    case (int)HttpStatusCode.InternalServerError:
                        logger.LogError(message);
                        break;
                    default:
                        logger.LogInformation(message);
                        break;
                }
            }
        }
    }

    public static class ActivityLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseActivityLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ActivityLoggingMiddleware>();
        }
    }

    
}
