using InventarApp.Application.Repositories;
using InventarApp.Domain.Entities;
using InventarApp.Infrastructre.DataBase;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventarApp.Infrastructre.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly InventarContext _context;
        public UsersRepository(InventarContext context)
        {
            _context = context;
        }

        public async Task<long> AddUser(User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }

        public async Task DeleteUser(User user)
        {
            _context.Users.Remove(user);

            await _context.SaveChangesAsync();
        }

        public Task<User> FindUserForAuthentication(string login, string password)
        {
            var user = _context.Users.FirstOrDefaultAsync(u => u.Login == login && u.Password == password);
            return user;
        }

        public async Task<User> GetUser(long id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }

        public async Task UpdateUser(User user)
        {

            _context.Users.Update(user);

            await _context.SaveChangesAsync();

        }
    }
}
