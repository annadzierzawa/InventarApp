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
    public class ResourcesController : ControllerBase
    {
        private readonly IResourcesService _resourceService;
        public ResourcesController(IResourcesService resourceService)
        {
            _resourceService = resourceService;
        }

        [Authorize(Roles = SystemRoles.Admin)]
        [HttpPost("add")]
        public async Task<IActionResult> AddResource(AddResourceCommand command)
        {
            await _resourceService.AddResource(command);

            return Ok();
        }

        [Authorize(Roles = SystemRoles.Admin)]
        [HttpDelete("delete/{id}")]
        public async Task DeleteResource(long id)
        {
            await _resourceService.DeleteResource(id);

        }

        [Authorize]
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateResource(long id, UpdateResourceCommand command)
        {
            command.Id = id;
            await _resourceService.UpdateResource(command);
            return Ok();
        }

        [Authorize]
        [HttpGet("all")]
        public async Task<List<ResourceDTO>> GetResources()
        {
            var resources = await _resourceService.GetResources();
            return resources;
        }
    }
}
