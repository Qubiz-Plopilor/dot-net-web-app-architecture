using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Services.Contracts.Models;

namespace WebApp.Core.Services.Contracts
{
	public interface IAccountService
	{
        /// <summary>
        /// Retrieve Accounts by Id.
        /// </summary>
        /// <param name="id">Account Id.</param>
        /// <returns>AccountInfoModel</returns>
        Task<AccountInfoModel> GetAccountById(int id);
    }
}
