using InventarApp.Api.Roles;
using InventarApp.Application.Commands;
using InventarApp.Application.DTOs;
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
    public class FailuresController : ControllerBase
    {
        private readonly IFailuresService _failuresService;
        public FailuresController(IFailuresService failuresService)
        {
            _failuresService = failuresService;
        }

        [Authorize(Roles = SystemRoles.LabTechnician)]
        [HttpPost("add")]
        public async Task<IActionResult> AddFailureReport(AddFailureCommand command)
        {
            await _failuresService.AddFailureReport(command);
            return Ok();
        }

        [Authorize(Roles = SystemRoles.LabTechnician)]
        [HttpDelete("delete/{id}")]
        public async Task DeleteFailureReport(long id)
        {
            await _failuresService.DeleteFailureReport(id);

         }
        [Authorize]
        [HttpGet("all-waiting")]
        public async Task<List<FailureReportShortDTO>> GetFailuresReportShort()
        {
            return await _failuresService.GetFailuresReportShort();
        }
    }
}
