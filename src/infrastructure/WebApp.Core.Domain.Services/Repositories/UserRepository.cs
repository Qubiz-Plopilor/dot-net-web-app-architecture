using WebApp.Core.Domain.Contracts.Repositories;
using WebApp.Core.Domain.Entities;
using WebApp.Core.Domain.Services.DBContext;

namespace WebApp.Core.Domain.Services.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
