using System;

namespace WebAppAndApi.Models
{
    public class Status
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public Status()
        {
        }

        public Status(int code)
        {
            this.Code = code;
        }

        public Status(int code, string message)
        {
            this.Code = code;
            this.Message = message;
        }
    }
}
