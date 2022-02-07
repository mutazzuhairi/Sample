using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Sample.Web.WebUtilities.HelperModels
{
    public class ValidationProblemDetailsResponse : ValidationProblemDetails
    {
        public ValidationProblemDetailsResponse() : base()
        {

        }
        public ValidationProblemDetailsResponse(IDictionary<string, string[]> errors) : base(errors) {
        
        }
        public string TraceId { set; get; }
    }
}
