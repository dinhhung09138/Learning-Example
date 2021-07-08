using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Movies.Client.Helpers
{
    public class HttpResponseWrapper<T> where T : class
    {

        public HttpResponseWrapper(T response, bool success, HttpResponseMessage responseMessage)
        {
            Success = success;
            Response = response;
            ResponseMessage = responseMessage;
        }

        public bool Success { get; set; }

        public T Response { get; set; }

        public HttpResponseMessage ResponseMessage { get; set; }

        public async Task<string> GetBody()
        {
            return await ResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
