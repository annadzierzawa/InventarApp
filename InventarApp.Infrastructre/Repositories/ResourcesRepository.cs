using InventarApp.Application.Repositories;
using InventarApp.Domain.Entities;
using InventarApp.Infrastructre.DataBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventarApp.Infrastructre.Repositories
{
    public class ResourcesRepository : IResourcesRepository
    {
        private readonly InventarContext _context;
        public ResourcesRepository(InventarContext context)
        {
            _context = context;
        }

        public async Task<long> AddResource(Resource resource)
        {
            _context.Add(resource);
            await _context.SaveChangesAsync();
            return resource.Id;
        }

        public async Task DeleteResource(Resource resource)
        {
            _context.Resources.Remove(resource);

            await _context.SaveChangesAsync();
        }

        public async Task<Resource> GetResource(long id)
        {
            var resource = await _context.Resources.FindAsync(id);
            return resource;
        }

        public async Task UpdateResource(Resource resource)
        {
            _context.Resources.Update(resource);
            await _context.SaveChangesAsync();
        }
    }
}
