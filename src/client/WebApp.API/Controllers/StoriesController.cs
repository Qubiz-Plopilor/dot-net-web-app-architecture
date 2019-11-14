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
    [OpenApiTag(name: "Instruments", Description = "Services dedicated for Instrument operations.")]
    public class StoriesController : ControllerBase
    {
        private readonly IStoriesService _storiesService;

        public StoriesController(IStoriesService storiesService)
        {
            _storiesService = storiesService;
        }

        // GET api/user/{id}/stories
        /// <summary>
        /// Get User stories
        /// </summary>
        /// <remarks>
        /// <para>Provides User stories.</para>
        /// </remarks>
        /// <response code="200">Ok, user stories returned.</response>
        [HttpGet("summary", Name = "GetUserStories")]
        [SwaggerResponse(200, typeof(IEnumerable<StoryInfoModel>), Description = "Ok, user stories returned.")]
        public async Task<IEnumerable<StoryInfoModel>> GetUserStories()
        {
            //return await _storiesService.GetUserStories();

            return null;
        }
    }
    }
