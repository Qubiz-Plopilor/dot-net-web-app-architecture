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
    [OpenApiTag(name: "Accounts", Description = "Services dedicated for managing Accounts.")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/accounts/{id}
        /// <summary>
        /// Get Account by Id
        /// </summary>
        /// <remarks>
        /// <para>Retrieve Account info by Id.</para>
        /// </remarks>
        /// <response code="200">Ok, article info returned.</response>
        [HttpGet("{id}", Name = "GetAccountById")]
        [SwaggerResponse(200, typeof(AccountInfoModel), Description = "Ok, account info returned.")]
        public async Task<AccountInfoModel> GetAccountById()
        {
            return await _accountService.GetAccountById(1);
        }
    }
}