using JWTAuthentication.Models;
using JWTAuthentication.Services;
using JWTAuthentication.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ITokenBuilderService _tokenBuilderService;

        public UsersController(IUserService userService, ITokenBuilderService tokenBuilderService)
        {
            _userService = userService;
            _tokenBuilderService = tokenBuilderService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            string token = _tokenBuilderService.GenerateToken(user.Id);

            return Ok(token);
        }
    }
}
