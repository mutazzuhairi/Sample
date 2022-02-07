using Sample.BLLayer.BLUtilities.HelperModels;
using System;
 
namespace Sample.Web.WebUtilities.Interfaces
{
    public interface IApiExceptionBuilder
    {
        public Response<object> BuildException(Exception ex);
     }
}
