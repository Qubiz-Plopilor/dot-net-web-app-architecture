using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Core.Domain.Entities;

namespace WebApp.Core.Services.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
    }
}
