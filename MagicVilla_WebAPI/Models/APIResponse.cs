using System.Net;

namespace MagicVilla_WebAPI.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
