using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Core.Domain.Entities
{
    public class Account : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual User User { get; set; }
    }
}
