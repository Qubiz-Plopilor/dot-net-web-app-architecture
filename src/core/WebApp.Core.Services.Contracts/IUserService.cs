using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Core.Domain.Entities;
using WebApp.Core.Services.Contracts.Models;

namespace WebApp.Core.Services.Contracts
{
    public interface IUserService
    {
        /// <summary>
        /// Retrieve User by Id.
        /// </summary>
        /// <param name="id">User Id.</param>
        /// <returns>UserInfoModel</returns>
        Task<UserInfoModel> GetUserById(int id);

        /// <summary>
        /// Add User by Id.
        /// </summary>
        Task<UserInfoModel> AddUser(UserInfoModel userInfoModel);
    }
}

