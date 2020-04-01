using System.Runtime.Serialization;

namespace MyPhotosApi.Api.Constants
{
    [DataContract(IsReference = true)]
    public class Response
    {
        [DataMember]
        public bool Succeeded { get; set; }
        [DataMember]
        public string Message { get; set; }

        public Response(bool succeeded, string message)
        {
            Succeeded = succeeded;
            Message = message;
        }
    }
}
