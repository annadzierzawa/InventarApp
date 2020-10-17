using InventarApp.Application.Repositories;
using InventarApp.Domain.Entities;
using InventarApp.Infrastructre.DataBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventarApp.Infrastructre.Repositories
{
    public class ResourcesRepository: IUsersRepository
    {
        private readonly InventarContext _context;
        public ResourcesRepository(InventarContext context)
        {
            _context = context;
        }

        public async Task<long> AddUser(User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }

        public void DeleteUser(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
