using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Services.Contracts.Models;

namespace WebApp.Core.Services.Contracts
{
    public interface IArticleService
    {
        /// <summary>
        /// Retrieve Article by Id.
        /// </summary>
        /// <param name="id">Article Id.</param>
        /// <returns>ArticleInfoModel</returns>
        Task<ArticleInfoModel> GetArticleById(int id);

        /// <summary>
        /// Retrieve Articles by User.
        /// </summary>
        /// <param name="userId">User Id.</param>
        /// <returns>List of ArticleInfoModel.</returns>
        Task<IEnumerable<ArticleInfoModel>> GetArticlesByUser(int userId);        
    }
}
