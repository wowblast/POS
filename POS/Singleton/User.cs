using POS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Singleton
{
    public sealed class User
    {
        private static User instance = null;

        public Usuario usuario;

        private User(Usuario usuarioSesion)
        {
            usuario = usuarioSesion;
        }

        public static User GetInstance(Usuario usuario)
        {
            if (instance == null)
            {
                instance = new User(usuario);
            }

            return instance;
        }

        public static User GetInstance()
        {
            if (instance == null)
            {
                instance = new User(new Usuario());
            }
            return instance;
        }
    }
}
