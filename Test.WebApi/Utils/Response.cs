using System;

namespace Test.WebApi.Utils
{
    public class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public object data { get; set; }
    }
}
