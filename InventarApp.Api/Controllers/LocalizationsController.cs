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
    public class LocalizationsController:ControllerBase
    {
        private readonly ILocalizationsService _localizationsService;

        public LocalizationsController(ILocalizationsService localizationsService)
        {
            _localizationsService = localizationsService;
        }

        [Authorize(Roles=SystemRoles.Admin)]
        [HttpPost("add")]
        public async Task<IActionResult> AddLocalization(AddLocalizationCommand command)
        {
            await _localizationsService.AddLocalization(command);
            return Ok();
        }
    }
}
