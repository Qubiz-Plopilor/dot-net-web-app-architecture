using WebApp.Core.Domain.Entities;
using WebApp.Core.Domain.Services.DBContext;

namespace WebApp.Core.Domain.Services.Repositories
{
	public class AccountRepository: GenericRepository<Account>
    {
        public AccountRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
