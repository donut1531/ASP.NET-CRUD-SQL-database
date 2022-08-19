using System;

namespace WebAppAndApi.Models
{
    public class ApiResponseModel<T>
    {
        public Status Status { get; set; }
        public T Data { get; set; }

        
    }
}