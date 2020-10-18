using System;
using System.Collections.Generic;
using System.Text;

namespace InventarApp.Application.Commands
{
    public class AuthenticateCommand
    {
        public string Login { get; set; }

        public string Password { get; set; }
    }
}
