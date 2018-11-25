using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_MATRICULA_V1.CLASES
{
    class Dadministradores
    {
        public string rut;
        public string nombre; 
        public string usuario;
        public string password;
        public string tipo_usuario;

        public string get_rut()
        {
            return rut;
        }

        public string get_nombre()
        {
            return nombre;
        }

        public string get_usuario()
        {
            return usuario;
        }

        public string get_password()
        {
            return password;
        }

        public string get_tipoUsuario()
        {
            return tipo_usuario;
        }

        public void set_rut(String value)
        {
            this.rut = value;
        }

        public void set_nombre(String value)
        {
            this.nombre = value;
        }

        public void set_usuario(String value)
        {
            this.usuario = value;
        }

        public void set_password(String value)
        {
            this.password = value;
        }

        public void set_tipoUsuario(String value)
        {
            this.tipo_usuario = value;
        }

    }
}
