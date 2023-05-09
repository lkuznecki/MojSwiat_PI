using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            // ?? if left side null execute right
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }



        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request",
                401 => "Not autohrized",
                404 => "Resource not found",
                500 => "Error",
                _ => null
            };
        }
    }
}