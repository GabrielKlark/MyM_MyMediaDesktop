using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUI
{
    class cl_User
    {
        private string login;
        private string pass;
        private string email;

        public string Login { get => login; set => login = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Email { get => email; set => email = value; }
    }
}
