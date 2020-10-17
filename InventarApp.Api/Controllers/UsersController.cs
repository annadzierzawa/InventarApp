using InventarApp.Application.Commands;
using InventarApp.Application.Services;
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

        [HttpPost("add")]
        public async Task<IActionResult> AddUser(AddUserCommand command)
        {
            await _usersService.AddUser(command);

            return Ok();
        }

    }
}
