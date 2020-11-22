using InventarApp.Application.Commands;
using InventarApp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventarApp.Application.Services
{
    public interface IResourcesService
    {
        Task<long> AddResource(AddResourceCommand command);
        Task DeleteResource(long id);
        Task UpdateResource(UpdateResourceCommand command);
        Task<List<ResourceDTO>> GetResources();
        Task<ResourceSerialNumberDTO> GetResourceBySerialNumber(Guid seriesNumber);
    }
}
