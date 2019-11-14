using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.API.Infrastructure.Models
{
    public class QueryPageDTO
    {
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
    }
}
