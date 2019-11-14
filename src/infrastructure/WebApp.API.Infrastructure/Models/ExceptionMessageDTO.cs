using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.API.Infrastructure.Models
{
    public class ExceptionMessageDTO : ErrorMessageDTO
    {
        public string StackTrace { get; private set; }

        public ExceptionMessageDTO(string message, string stackTrace)
            : base(message)
        {
            StackTrace = stackTrace;
        }

        public ExceptionMessageDTO(List<string> messages)
            : base(messages)
        {
        }
    }
}
