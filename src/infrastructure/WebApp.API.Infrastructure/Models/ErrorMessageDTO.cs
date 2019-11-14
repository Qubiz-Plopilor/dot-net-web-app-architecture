using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.API.Infrastructure.Models
{
    public class ErrorMessageDTO
    {
        public List<string> Messages { get; private set; }

        public ErrorMessageDTO(string message)
        {
            this.Messages = new List<string>();

            if (!string.IsNullOrWhiteSpace(message))
            {
                this.Messages.Add(message);
            }
        }

        public ErrorMessageDTO(List<string> messages)
        {
            this.Messages = messages ?? new List<string>();
        }
    }
}
