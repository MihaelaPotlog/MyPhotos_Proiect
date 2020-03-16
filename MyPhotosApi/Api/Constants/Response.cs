namespace MyPhotosApi.Api.Constants
{
    public class Response
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }

        public Response(bool succeeded, string message)
        {
            Succeeded = succeeded;
            Message = message;
        }
    }
}
