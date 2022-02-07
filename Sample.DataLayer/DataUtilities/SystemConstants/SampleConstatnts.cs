 
namespace Sample.DataLayer.DataUtilities.SystemConstants
{
    public class SampleConstatnts
    {
        public class ConnectionString
        {
            public const string SAMPLE = "SampleConnectionString";
        }
        public class AppSettings
        {
            public const string JWT_SETTINGS = "JwtSettings";
            public const string SECURITY_KEY = "SecurityKey";
            public const string EXPIRY_IN_MINUTEW = "ExpiryInMinutes";
        }
        public class SwaggerProperites
        {
            public const string SWAGGER_ROUTE = "/api/swagger/v1/swagger.json";
            public const string SWAGGER_TITLE = "Sample.Web";
            public const string SWAGGER_NAME = "Sample.Web v1";
            public const string SWAGGER_VERSION = "v1";
            public const string SWAGGER_ROUTE_TEMPLATE = "api/swagger/{documentname}/swagger.json";
            public const string SWAGGER_PATH = "api/swagger";

        }
        public class SqlServerDefaultValues
        {
            public const string SYSTEM = "'System'";
            public const string BOOLEAN_FALSE = "(0)";
            public const string CURRENT_DATE_TIME_OFFSET = "(sysdatetimeoffset())";
        }
  
    }
}
