using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Infrastructure.Services.Contracts
{
    public interface ICacheService
    {
        void Remove(string key);
        void Store(string key, object data);
        T Retrieve<T>(string storageKey) where T : class;
    }
}
