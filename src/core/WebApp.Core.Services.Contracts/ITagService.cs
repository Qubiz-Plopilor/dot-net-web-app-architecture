using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Services.Contracts.Models;

namespace WebApp.Core.Services.Contracts
{
	public interface ITagService
	{
        /// <summary>
        /// Retrieve Tags by Id.
        /// </summary>
        /// <param name="id">Tag Id.</param>
        /// <returns>TagInfoModel</returns>
        Task<TagInfoModel> GetTagById(int id);
    }
}
