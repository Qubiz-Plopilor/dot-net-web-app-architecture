using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.Persistence.DBContext;

namespace WebApp.Domain.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
