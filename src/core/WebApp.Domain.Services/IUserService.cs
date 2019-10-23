using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Domain.Services.Contract
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
    }
}
