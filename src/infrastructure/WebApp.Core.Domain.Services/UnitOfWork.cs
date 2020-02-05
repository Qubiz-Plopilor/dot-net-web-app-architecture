using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Core.Domain.Contracts;
using WebApp.Core.Domain.Contracts.Repositories;
using WebApp.Core.Domain.Services.DBContext;
using WebApp.Core.Domain.Services.Repositories;

namespace WebApp.Core.Domain.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _isDisposed;
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

            UserRepository = new UserRepository(dbContext);
        }

        public IUserRepository UserRepository { get; set; }

        public UnitOfWork(string connection)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlServer(connection)
                    .Options;

            _dbContext = new ApplicationDbContext(options);
        }

        public async Task<int> Commit()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Rollback()
        {
            _dbContext.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
        }

        #region Dispose

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
