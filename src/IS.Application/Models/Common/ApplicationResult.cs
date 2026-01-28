using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.Application.Models.Common
{
    public enum ApplicationResultStatus
    {
        Failed = 0,
        Success = 1,
        Warning = 2
    }

    public class ApplicationResult
    {
        public string? Message { get; set; }
        public ApplicationResultStatus Status { get; set; }
    }

    public class ApplicationResult<T> : ApplicationResult
    {
        public required T Data { get; set; }
    }
}
