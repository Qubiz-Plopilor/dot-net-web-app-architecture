using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Persistence.Contract
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Commit();

        void Rollback();
    }
}
