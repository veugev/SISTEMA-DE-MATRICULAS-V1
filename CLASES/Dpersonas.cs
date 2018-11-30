using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_MATRICULA_V1
{
    class Dpersonas
    {
        string rut_p;
        string nombre_p;
        string nacionalidad_p;
        string direccion_p;
        int comuna_p;
        string nivel_educacional;
        string ocupacion;
        string fono_p;
        int parentezco;
        string mail;
        string rut_e;
        int estado_apod;


        public string get_rut_p()
        {
            return rut_p;
        }

        public void set_rut_p(String value)
        {
            this.rut_p = value;
        }

        public string get_nombre_p()
        {
            return nombre_p;
        }

        public void set_nombre_p(String value)
        {
            this.nombre_p = value;
        }

        public string get_nacionalidad_p()
        {
            return nacionalidad_p;
        }

        public void set_nacionalidad_p(String value)
        {
            this.nacionalidad_p = value;
        }

        public string get_direccion_p()
        {
            return direccion_p;
        }

        public void set_direccion_p(String value)
        {
            this.direccion_p = value;
        }
        
        public int get_comuna_p()
        {
            return comuna_p;
        }

        public void set_comuna_p(Int32 value)
        {
            this.comuna_p = value;
        }

        public string get_nivel_educacional()
        {
            return nivel_educacional;
        }

        public void set_nivel_educacional(String value)
        {
            this.nivel_educacional = value;
        }

        public string get_ocupacion()
        {
            return ocupacion;
        }

        public void set_ocupacion(String value)
        {
            this.ocupacion = value;
        }

        public string get_fono_p()
        {
            return fono_p;
        }

        public void set_fono_p(String value)
        {
            this.fono_p = value;
        }

        public int get_parentezco()
        {
            return parentezco;
        }

        public void set_parentezco(Int32 value)
        {
            this.parentezco= value;
        }

        public string get_mail()
        {
            return mail;
        }

        public void set_mail(String value)
        {
            this.mail = value;
        }

        public string get_rut_e()
        {
            return rut_e;
        }

        public void set_rut_e(String value)
        {
            this.rut_e = value;
        }

        public int get_estado_apod()
        {
            return estado_apod;
        }

        public void set_estado_apod(Int32 value)
        {
            this.estado_apod = value;
        }
    }
}
