using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_MATRICULA_V1.CLASES
{
    class Ddirectivos
    {
        public string nick;
        public string contras;
        public string nombre;
        public string usuario;

        public string get_nick()
        {
            return nick;
        }

        public string get_contras()
        {
            return contras;
        }
        public string get_nombre()
        {
            return nombre;
        }

        public string get_usuario()
        {
            return usuario;
        }

        public void set_nick(String value)
        {
            this.nick = value;
        }

        public void set_contras(String value)
        {
            this.contras = value;
        }
        public void set_nombre(String value)
        {
            this.nombre = value;
        }

        public void set_usuario(String value)
        {
            this.usuario = value;
        }
    }
}
