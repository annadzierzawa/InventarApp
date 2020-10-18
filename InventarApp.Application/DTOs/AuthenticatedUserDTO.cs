using InventarApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarApp.Application.DTOs
{
    public class AuthenticatedUserDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public RoleEnum Role { get; set; }
        public string Token { get; set; }

        public AuthenticatedUserDTO(long id, string name, string surname, string login, RoleEnum role, string token)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Login = login;
            Role = role;
            Token = token;
        }
    }
}
