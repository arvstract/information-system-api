using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.API.Common.Model
{
    public enum ApiResponseStatus
    {
        Failed = 0,
        Success = 1,
        Warning = 2
    }

    public class ApiResponse
    {
        public string? Message { get; set; }
        public ApiResponseStatus Status { get; set; }
    }

    public class ApiResponse<T>: ApiResponse
    {
        public required T Data { get; set; }
    }
}
