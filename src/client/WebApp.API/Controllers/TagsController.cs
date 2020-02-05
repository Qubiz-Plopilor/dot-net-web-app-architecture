using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using WebApp.Core.Services.Contracts;
using WebApp.Core.Services.Contracts.Models;

namespace WebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [OpenApiTag(name: "Tags", Description = "Services dedicated for managing Tags.")]
    public class TagsController : Controller
    {
        private readonly ITagService _tagService;

        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        // GET api/tags/{id}
        /// <summary>
        /// Get Tags by Id
        /// </summary>
        /// <remarks>
        /// <para>Retrieve Tag info by Id.</para>
        /// </remarks>
        /// <response code="200">Ok, tag info returned.</response>
        [HttpGet("{id}", Name = "GetTagById")]
        [SwaggerResponse(200, typeof(TagInfoModel), Description = "Ok, tag info returned.")]
        public async Task<TagInfoModel> GetTagById()
        {
            return await _tagService.GetTagById(1);
        }
    }
}