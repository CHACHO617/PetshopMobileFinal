using PetshopMobileProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetshopMobileProgreso2
{
    public static class UsersLogin
    {
        private static readonly List<Usuario> _u = new List<Usuario>
        {
            new Usuario {Username = "emerizalde", Password = "EnriqueMerizalde"},
            new Usuario {Username = "mcedenio", Password = "MatiasCedenio"}
        };

        public static List<Usuario> GetUsuarios()
        {
            return _u;
        }

        public class Usuario
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

    }
}
