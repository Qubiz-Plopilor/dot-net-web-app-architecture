using WebApp.Core.Domain.Entities;
using WebApp.Core.Domain.Services.DBContext;

namespace WebApp.Core.Domain.Services.Repositories
{
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
