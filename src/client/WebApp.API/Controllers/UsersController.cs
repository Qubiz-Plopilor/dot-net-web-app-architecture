using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NSwag.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Services.Contracts;
using WebApp.Core.Services.Contracts.Models;

namespace WebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [OpenApiTag(name: "Users", Description = "Services dedicated for managing Users.")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET api/users/{id}
        /// <summary>
        /// Get User by Id
        /// </summary>
        /// <remarks>
        /// <para>Retrieve User info by Id.</para>
        /// </remarks>
        /// <response code="200">Ok, user info returned.</response>
        [HttpGet("{id}", Name = "GetUserById")]
        [SwaggerResponse(200, typeof(UserInfoModel), Description = "Ok, user info returned.")]
        public async Task<UserInfoModel> GetUserById(int id)
        {
            return await _userService.GetUserById(id);
        }

        // POST api/users
        /// <summary>
        /// Add User
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <response code="201">Ok, user info added.</response>
        [HttpPost("{id}", Name = "AddUser")]
        [SwaggerResponse(201, typeof(UserInfoModel), Description = "Ok, user info returned.")]
        public async Task<ActionResult<UserInfoModel>> AddUser(int id, [FromBody][Required]UserInfoModel userInfoModel)
        {
            //
            var model = userInfoModel;
            _userService.AddUser(userInfoModel);
            //
            //_context.Update(model);
            // await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserById", id);
        }
    }
}

