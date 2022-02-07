using Microsoft.AspNetCore.Mvc;

namespace Sample.Web.WebUtilities.HelperModels
{
    public class ProblemDetailsResponse : ProblemDetails
    {
        public string TraceId { set; get; }
    }
}
