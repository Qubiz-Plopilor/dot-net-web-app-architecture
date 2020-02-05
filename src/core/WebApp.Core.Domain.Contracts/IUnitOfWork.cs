using System;
using System.Threading.Tasks;
using WebApp.Core.Domain.Contracts.Repositories;

namespace WebApp.Core.Domain.Contracts
{
    public interface IUnitOfWork : IDisposable
    {              
        public IUserRepository UserRepository { get; set; }

        Task<int> Commit();

        void Rollback();
    }
}
