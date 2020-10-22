using InventarApp.Application.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventarApp.Application.Services
{
    public interface IResourcesService
    {
        Task<long> AddResource(AddResourceCommand command);
        Task DeleteResource(long id);
        Task UpdateResource(UpdateResourceCommand command);
    }
}
