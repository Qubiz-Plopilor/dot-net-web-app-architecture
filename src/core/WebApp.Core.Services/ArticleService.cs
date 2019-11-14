using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Services.Contracts;
using WebApp.Core.Services.Contracts.Models;
using WebApp.Core.Domain.Contracts.Exceptions;

namespace WebApp.Core.Services
{
    public class ArticleService : IArticleService
    {
        public async Task<IEnumerable<ArticleInfoModel>> GetArticlesByUser(int userId)
        {
            throw new EntityNotFoundException($"Article not found!");

            return new List<ArticleInfoModel>
            {
                new ArticleInfoModel
                {
                    Id = 1,
                    UniqueId = Guid.NewGuid(),
                    DateCreated = DateTime.Now,
                    UserId = 1,
                    Content = "Nu-i circul tau, nu-s maimutele tale."
                },
                new ArticleInfoModel
                {
                    Id = 2,
                    UniqueId = Guid.NewGuid(),
                    DateCreated = DateTime.Now,
                    UserId = 1,
                    Content = "There is a fine line between killing a fly and applauding a fly"
                }
            };
        }

        public async Task<ArticleInfoModel> GetArticleById(int id)
        {
            throw new EntityNotFoundException($"Article with Id = {id} not found!");
        }
    }
}
