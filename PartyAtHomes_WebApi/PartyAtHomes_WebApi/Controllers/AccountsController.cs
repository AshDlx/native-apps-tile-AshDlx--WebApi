using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PartyAtHomes_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        AccountsController _accountsController;
        public AccountsController(AccountsController accountsController)
        {
            _accountsController = accountsController;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register()
        {
            return Ok();
        }
    }
}