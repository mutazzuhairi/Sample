using Sample.BLLayer.BLUtilities.HelperServices;
using Sample.Web.WebUtilities.HelperModels;
using Sample.Web.WebUtilities.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Transactions;

namespace Sample.Web.WebUtilities.Middlewares
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, Lazy<ITransactionFactory> transactionFactory)
        {
            try
            {
                using TransactionScope scope = transactionFactory.Value.GetAsyncTransaction();
                await _next(context);
                scope.Complete();
            }
            catch (AppException ex)
            {
                if (ex.validationProblemDetails != null)
                {
                    await HandleExceptionAsync(context, ex, (int)HttpStatusCode.BadRequest, "One or more validation errors occurred.", (Dictionary<string, string[]>)ex.validationProblemDetails.Errors);
                }
                else if (ex.problemDetails != null)
                {
                    await HandleExceptionAsync(context, ex, (int)HttpStatusCode.Forbidden, "Forbidden.", new Dictionary<string, string[]>() { { ex.problemDetails.Title, new[] { ex.problemDetails.Detail } } });
                }
                else
                {
                    await HandleExceptionAsync(context, ex, (int)HttpStatusCode.BadRequest, "One or more validation errors occurred.", new Dictionary<string, string[]>() { { ex.Message, new[] { ex.Message } } });
                }
                throw;
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, (int)HttpStatusCode.InternalServerError, "Oops! Something Went Wrong");
                throw;
            }
        }

        private static Task HandleExceptionAsync(HttpContext context,
                                                 Exception exception,
                                                 int code,
                                                 string title,
                                                 Dictionary<string, string[]> errors = null)
        {


            var exceptionStatus = code;
            var exceptionTitle = title;
            var exceptionTraceId = Activity.Current?.Id ?? context?.TraceIdentifier;
            var exceptionMessage = exception.Message;

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = exceptionStatus;

            string result;

            Dictionary<string, string[]> encodedErrors = new Dictionary<string, string[]>();

            if (errors != null)
                encodedErrors = errors.ToDictionary(key => WebUtility.HtmlEncode(key.Key), value => value.Value.Select(err => WebUtility.HtmlEncode(err)).ToArray());

            if (code == (int)HttpStatusCode.BadRequest)
            {
                var problem = new ValidationProblemDetailsResponse(encodedErrors)
                {
                    Status = exceptionStatus,
                    Title = exceptionTitle,
                    TraceId = exceptionTraceId
                };
                result = JsonConvert.SerializeObject(problem, new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });
            }
            else
            {
                var problem = new ProblemDetailsResponse()
                {
                    Status = exceptionStatus,
                    Title = exceptionTitle,
                    TraceId = exceptionTraceId,
                    Detail = exceptionMessage
                };
                problem.Extensions["errors"] = encodedErrors;
                result = JsonConvert.SerializeObject(problem, new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });

            }

            return context.Response.WriteAsync(result);
        }
    }

    public static class ErrorHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}
