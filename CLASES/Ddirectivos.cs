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

        public string get_nick()
        {
            return nick;
        }

        public string get_contras()
        {
            return contras;
        }

        public void set_nick(String value)
        {
            this.nick = value;
        }

        public void set_contras(String value)
        {
            this.contras = value;
        }
    }
}
