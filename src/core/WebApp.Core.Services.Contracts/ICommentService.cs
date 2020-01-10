using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Services.Contracts.Models;

namespace WebApp.Core.Services.Contracts
{
	public interface ICommentService
	{
        /// <summary>
        /// Retrieve Comments by Id.
        /// </summary>
        /// <param name="id">Comment Id.</param>
        /// <returns>CommentInfoModel</returns>
        Task<CommentInfoModel> GetCommentById(int id);
    }
}
