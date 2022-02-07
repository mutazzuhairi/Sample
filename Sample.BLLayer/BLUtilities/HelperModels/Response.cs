
namespace Sample.BLLayer.BLUtilities.HelperModels
{
    public class Response<T>
    {
        public Response()
        {
        }
        public Response(T data)
        {
            Succeeded = true;
            ErrorMessage = string.Empty;
            ErrorType = null;
            Data = data;
        }
        public T Data { get; set; }
        public bool Succeeded { get; set; }
        public string  ErrorType { get; set; }
        public string ErrorMessage { get; set; }
 
    }
}
