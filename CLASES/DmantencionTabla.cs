using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_MATRICULA_V1.CLASES
{
    class DmantencionTabla
    {
        public int Id_anio;
        public string descripcion;
        public int Id_comuna;
        public string desc;
        public int Id_profesor;
        public string descrip;


        public int get_Id_anio()
        {
            return Id_anio;
        }

        public string get_descripcion()
        {
            return descripcion;
        }

        public int get_Id_comuna()
        {
            return Id_comuna;
        }

        public string get_desc()
        {
            return desc;
        }

        public int get_Id_profesor()
        {
            return Id_profesor;
        }

        public string get_descrip()
        {
            return descrip;
        }

        public void set_Id_anio(int value)
        {
            this.Id_anio = value;
        }

        public void set_descripcion(String value)
        {
            this.descripcion = value;
        }

        public void set_Id_comuna(int value)
        {
            this.Id_comuna = value;
        }

        public void set_desc(String value)
        {
            this.desc = value;
        }

        public void set_Id_profesor(int value)
        {
            this.Id_profesor = value;
        }

        public void set_descrip(String value)
        {
            this.descrip = value;
        }
    }
}
