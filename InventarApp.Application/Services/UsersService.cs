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
        public void DeleteUser(long id)
        {
            _usersRepository.DeleteUser(id);
        }

        //public async Task UpdateUser(UpdateUserCommand command)
        //{

        //    await _usersRepository.UpdateUser(user);
        //}
    }
}
