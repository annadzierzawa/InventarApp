﻿using InventarApp.Application.Commands;
using InventarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventarApp.Application.Repositories
{
    public interface IUsersRepository
    {
        Task<long> AddUser(User user);
        void DeleteUser(long id);
        Task UpdateUser(User user);
        Task<User> GetUser(long id);
    }
}
