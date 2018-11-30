using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_MATRICULA_V1
{
    class DfichaMatri
    {
        int Nro_Matricula;
        int anio;
        int tipoalumno;
        int estadoalum;
        int profesor;
        int tipo_ensenanza;
        int grado;
        int curso;
        string fecha_ingreso;
        string fecha_retiro;
        string fecha_egreso;
        int id_Rut;


        public int get_Nro_Matricula()
        {
            return Nro_Matricula;
        }

        public void set_Nro_Matricula(Int32 value)
        {
            this.Nro_Matricula = value;
        }

        public int get_anio()
        {
            return anio;
        }

        public void set_anio(Int32 value)
        {
            this.anio = value;
        }

        public int get_tipoalumno()
        {
            return tipoalumno;
        }

        public void set_tipoalumno(Int32 value)
        {
            this.tipoalumno = value;
        }

        public int get_estadoalum()
        {
            return estadoalum;
        }

        public void set_estadoalum(Int32 value)
        {
            this.estadoalum = value;
        }

        public int get_profesor()
        {
            return profesor;
        }

        public void set_profesor(Int32 value)
        {
            this.profesor = value;
        }

        public int get_tipoensenanza()
        {
            return tipo_ensenanza;
        }

        public void set_tipoensenanza(Int32 value)
        {
            this.tipo_ensenanza = value;
        }

        public int get_grado()
        {
            return grado;
        }

        public void set_grado(Int32 value)
        {
            this.grado = value;
        }

        public Int32 get_curso()
        {
            return curso;
        }

        public void set_curso(Int32 value)
        {
            this.curso = value;
        }

        public String get_fechaingreso()
        {
            return fecha_ingreso;
        }

        public void set_fechaingreso(String value)
        {
            this.fecha_ingreso = value;
        }

        public String get_fecharetiro()
        {
            return fecha_retiro;
        }

        public void set_fecharetiro(String value)
        {
            this.fecha_retiro = value;
        }

        public String get_fechaegreso()
        {
            return fecha_egreso;
        }

        public void set_fechaegreso(String value)
        {
            this.fecha_egreso = value;
        }

        public int get_rut_p()
        {
            return id_Rut;
        }

        public void set_rut_p(Int32 value)
        {
            this.id_Rut = value;
        }
    }
}
