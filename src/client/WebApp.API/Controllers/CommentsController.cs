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
    [OpenApiTag(name: "Comments", Description = "Services dedicated for managing Comments.")]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        // GET api/comments/{id}
        /// <summary>
        /// Get Comment by Id
        /// </summary>
        /// <remarks>
        /// <para>Retrieve Comment info by Id.</para>
        /// </remarks>
        /// <response code="200">Ok, comment info returned.</response>
        [HttpGet("{id}", Name = "GetCommentById")]
        [SwaggerResponse(200, typeof(CommentInfoModel), Description = "Ok, comment info returned.")]
        public async Task<CommentInfoModel> GetCommentById()
        {
            return await _commentService.GetCommentById(1);
        }
    }
}