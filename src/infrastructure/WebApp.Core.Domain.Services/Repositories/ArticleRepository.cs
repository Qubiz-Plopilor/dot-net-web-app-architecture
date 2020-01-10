using WebApp.Core.Domain.Entities;
using WebApp.Core.Domain.Services.DBContext;

namespace WebApp.Core.Domain.Services.Repositories
{
    public class ArticleRepository : GenericRepository<Article>
    {
        public ArticleRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
