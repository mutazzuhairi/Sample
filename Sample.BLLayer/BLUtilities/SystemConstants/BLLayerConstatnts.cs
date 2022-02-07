
namespace Sample.BLLayer.BLUtilities.SystemConstants
{
    public class BLLayerConstatnts
    {
        public class ConnectionString
        {
            public const string SAMPLE = "SampleConnectionString";
        }
        public class ValidationMessage
        {
            public const string EMAIL_NOT_VALID = "The email is invalid..";
            public const string USER_NAME_ALREADY_EXIST = "This UserName already exist.";
        }
        public class AppSettings
        {
            public const string JWT_SETTINGS = "JwtSettings";
            public const string SECURITY_KEY = "SecurityKey";
            public const string EXPIRY_IN_MINUTEW = "ExpiryInMinutes";
        }
    }
}
