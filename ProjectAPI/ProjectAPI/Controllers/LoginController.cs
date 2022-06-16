using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    [Route("login")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly ILoginLogic _loginLogic;
        public LoginController(ILoginLogic loginLogic)
        {
            _loginLogic = loginLogic;
        }
        [HttpPost]
        public async Task<IActionResult> Login(string login, string password)
        {
            try
            {
                await _loginLogic.Login(login,password);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
