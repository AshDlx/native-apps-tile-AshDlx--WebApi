using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyAtHomes_Lib;
using PartyAtHomes_WebApi.Repositories;

namespace PartyAtHomes_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        AccountRepository _accountsRepository;
        public AccountsController(AccountRepository accountsRepository)
        {
            _accountsRepository = accountsRepository;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto login)
        {
            if (await _accountsRepository.Login(login) != null)
            {
                return Ok(await _accountsRepository.Login(login));
            }

            return BadRequest();
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDto register)
        {
            return Ok(await _accountsRepository.Register(register));
        }
    }
}