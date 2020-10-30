using InventarApp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventarApp.Application.Repositories
{
    public interface IResourcesRepository
    {
        Task<long> AddResource(Resource resource);
        Task DeleteResource(Resource resource);
        Task<Resource> GetResource(long id);
        Task UpdateResource(Resource resource);
        Task<List<Resource>> GetResources();
    }
}
