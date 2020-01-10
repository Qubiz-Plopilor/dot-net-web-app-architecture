using WebApp.Core.Domain.Entities;
using WebApp.Core.Domain.Services.DBContext;

namespace WebApp.Core.Domain.Services.Repositories
{
    public class TagRepository : GenericRepository<Tag>
    {
        public TagRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
