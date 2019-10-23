using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Domain.Services.Contract
{
    public class UserService : IUserService
    {
        public UserService()
        {

        }
        
        public async Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
