using System.Linq;
using System.Net;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Sample.BLLayer.BLUtilities.HelperServices
{
    public class ServiceBuildException : IServiceBuildException
    {
        public void BuildException(string title, string errorMessage)
        {
            var validationProblemDetails = new ValidationProblemDetails()
            {
                Errors = { },
                Title = "One or more validation errors occurred",
            };
            validationProblemDetails.Errors.Add(title, new string[] { errorMessage });
            throw new AppException(validationProblemDetails);
        }
    }
}
