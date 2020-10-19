using InventarApp.Api.Roles;
using InventarApp.Application.Commands;
using InventarApp.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]                      //tym postem strzelamy po token
        public async Task<IActionResult> Authenticate([FromBody]AuthenticateCommand command)
        {
            var user = await _usersService.Authenticate(command.Login, command.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [Authorize(Roles=SystemRoles.Admin)]   //autoryzuje po roli
        [HttpPost("add")]
        public async Task<IActionResult> AddUser(AddUserCommand command)
        {
            await _usersService.AddUser(command);

            return Ok();
        }

        [Authorize(Roles = SystemRoles.Admin)]
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateUser(long id, UpdateUserCommand command)
        {
            command.Id = id;
            await _usersService.UpdateUser(command);
            return Ok();

        }

        [Authorize(Roles = SystemRoles.Admin)]
        [HttpDelete("delete/{id}")]
        public async Task DeleteUser(long id)
        {
           await _usersService.DeleteUser(id);
        }

    }
}
