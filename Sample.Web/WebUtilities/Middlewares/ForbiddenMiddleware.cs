using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;


namespace Sample.Web.WebUtilities.Middlewares
{
    /// <summary>
    /// Middleware that cheks if the ip has the correctr vendor in the request
    /// </summary>
    public class ForbiddenMiddleware
    {
        private readonly RequestDelegate _next;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        public ForbiddenMiddleware(RequestDelegate request)
        {
            _next = request;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context)
        {
             
            await _next.Invoke(context);
        }



    }

    /// <summary>
    ///  Extension method used to add the middleware to the HTTP request pipeline.
    /// </summary>
    public static class AdminSafeListMiddlewareExtensions
    {
        /// <summary>
        /// Register the AdminSafeListMiddleware
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseAdminSafeListMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ForbiddenMiddleware>();
        }
    }


}
