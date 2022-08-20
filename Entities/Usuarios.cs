using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuarios
    {
        private int _IdUser;
        private string _Usuario;
        private string _Password;
        private string _Roles;

        public int IdUser { get => _IdUser; set => _IdUser = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Roles { get => _Roles; set => _Roles = value; }
    }
}
