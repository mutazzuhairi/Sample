using Microsoft.AspNetCore.Mvc;
using System;

namespace Sample.BLLayer.BLUtilities.HelperServices
{
    public class AppException : Exception
    {
        public ValidationProblemDetails validationProblemDetails { get; set; }
        public ProblemDetails problemDetails { get; set; }

        private string _propertyName;

        public string PropertyName
        {
            get
            {
                return _propertyName;
            }
            set
            {
                if (value != null)
                {
                    _propertyName = value;
                }
            }
        }

        public AppException(string message, Exception ex, string propertyName) : base(message, ex)
        {
            _propertyName = propertyName;
        }

        public AppException(ValidationProblemDetails validationProblemDetails)
        {
            this.validationProblemDetails = validationProblemDetails;
        }

        public AppException(ProblemDetails problemDetails)
        {
            this.problemDetails = problemDetails;
        }

        public AppException(string message, ProblemDetails problemDetails) : base(message)
        {
            this.problemDetails = problemDetails;
        }
        public AppException(string message) : base(message)
        {
            this.validationProblemDetails = new ValidationProblemDetails()
            {
                Errors = { },
                Title = "One or more validation errors occurred",
            };
            validationProblemDetails.Errors.Add(message, new string[] { message });
        }

    }
}
