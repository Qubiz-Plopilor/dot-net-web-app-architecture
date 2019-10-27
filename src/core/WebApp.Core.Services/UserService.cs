using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Core.Domain.Entities;
using WebApp.Core.Services.Contracts;

namespace WebApp.Core.Services
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
