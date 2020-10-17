using InventarApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarApp.Application.Commands
{
    public class UpdateUserCommand
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public RoleEnum Role { get; set; }
    }
}
