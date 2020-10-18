using InventarApp.Application.Commands;
using InventarApp.Application.Repositories;
using InventarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventarApp.Application.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public async Task<long> AddUser(AddUserCommand command)
        {
            var user = new User()
            {
                Name = command.Name,
                Surname = command.Surname,
                Login = command.Login,
                Password = command.Password,
                Role = command.Role

            };

            return await _usersRepository.AddUser(user);
        }
        public async Task DeleteUser(long id)
        {
            var user = await _usersRepository.GetUser(id);
            if (user is null)
            {
                throw new Exception("User does not exist");
            }

             await _usersRepository.DeleteUser(user);
        }

        public async Task UpdateUser(UpdateUserCommand command)
        {
            var user = await _usersRepository.GetUser(command.Id);
            if (user is null)
            {
                throw new Exception("User does not exist");
            }

            user.Name = command.Name;
            user.Surname = command.Surname;
            user.Role = command.Role;
            await _usersRepository.UpdateUser(user);
        }
    }
}
