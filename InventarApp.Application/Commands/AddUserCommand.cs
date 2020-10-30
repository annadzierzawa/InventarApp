﻿using InventarApp.Domain.Enums;

namespace InventarApp.Application.Commands
{
    public class AddUserCommand
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; }
    }
}
