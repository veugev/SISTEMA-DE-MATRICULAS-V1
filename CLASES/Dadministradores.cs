using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_MATRICULA_V1.CLASES
{
    class Dadministradores
    {
        public string usuario;
        public string password;

        public string get_usuario()
        {
            return usuario;
        }

        public string get_password()
        {
            return password;
        }

        public void set_usuario(String value)
        {
            this.usuario = value;
        }

        public void set_password(String value)
        {
            this.password = value;
        }

    }
}
