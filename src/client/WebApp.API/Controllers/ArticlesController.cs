using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Services.Contracts;
using WebApp.Core.Services.Contracts.Models;

namespace WebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [OpenApiTag(name: "Articles", Description = "Services dedicated for managing Articles.")]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        // GET api/articles/{id}
        /// <summary>
        /// Get Article by Id
        /// </summary>
        /// <remarks>
        /// <para>Retrieve Article info by Id.</para>
        /// </remarks>
        /// <response code="200">Ok, article info returned.</response>
        [HttpGet("{id}", Name = "GetArticleById")]
        [SwaggerResponse(200, typeof(ArticleInfoModel), Description = "Ok, article info returned.")]
        public async Task<ArticleInfoModel> GetArticleById()
        {
            return await _articleService.GetArticleById(1);
        }

        // GET api/user/{id}/articles
        /// <summary>
        /// Get User Articles
        /// </summary>
        /// <remarks>
        /// <para>Provides User Articles.</para>
        /// </remarks>
        /// <response code="200">Ok, user articles returned.</response>
        [HttpGet("/api/user/{id}/articles", Name = "GetArticlesByUser")]
        [SwaggerResponse(200, typeof(IEnumerable<ArticleInfoModel>), Description = "Ok, user articles returned.")]
        public async Task<IEnumerable<ArticleInfoModel>> GetArticlesByUser()
        {
            return await _articleService.GetArticlesByUser(1);
        }
    }
}
