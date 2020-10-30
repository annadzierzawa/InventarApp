using InventarApp.Application.Commands;
using InventarApp.Application.DTOs;
using InventarApp.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventarApp.Application.Services
{
    public interface IUsersService
    {
        Task<long> AddUser(AddUserCommand command);
        Task DeleteUser(long id);
        Task UpdateUser(UpdateUserCommand command);
        Task<AuthenticatedUserDTO> Authenticate(string username, string password);
        Task<List<UserDTO>> GetAllUsers();
    }
}
