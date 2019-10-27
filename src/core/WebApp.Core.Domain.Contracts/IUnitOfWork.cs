using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Core.Domain.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Commit();

        void Rollback();
    }
}
