using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SISTEMA_DE_MATRICULA_V1
{
    class FichaMatriSQL
    {
        private BdConexion Conexion = new BdConexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable Listar_anio()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Anio";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void InsertarMatri(DfichaMatri dtp)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insert into Ficha_Matricula values('" + dtp.get_anio() + "','" + dtp.get_tipoalumno() + "'," +
                                                            "'" + dtp.get_estadoalum() + "','" + dtp.get_profesor() + "','" + dtp.get_tipoensenanza() + "'," +
                                                            "'" + dtp.get_grado() + "','" + dtp.get_curso() + "','" + dtp.get_fechaingreso() + "'," +
                                                            "'" + dtp.get_fecharetiro() + "','" + dtp.get_fechaegreso() + "','" + dtp.get_rut_p() + "')";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

        public DataTable Listar_Personas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_apoderado";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listar_Matriculas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Matriculas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listar_tipoalumno()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_TipoAlumno";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listar_estadoalum()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_EstadoAlum";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void ModificarMatri(DfichaMatri dtp)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Update Personas  set id_anio = '" + dtp.get_anio() + "', id_tipoalumno = '" + dtp.get_tipoalumno() + "'," +
                                                            "id_estadoalum = '" + dtp.get_estadoalum() + "',id_profesor ='" + dtp.get_profesor() + "', id_tipo_ensenaza ='" + dtp.get_tipoensenanza() + "'," +
                                                            "id_grado = '" + dtp.get_grado() + "',id_curso = '" + dtp.get_curso() + "', Fecha_ingreso ='" + dtp.get_fechaingreso() + "'," +
                                                            "Fecha_retiro = '" + dtp.get_fecharetiro() + "', Fecha_egreso = '" + dtp.get_fechaegreso() + "', id_rut ='" + dtp.get_rut_p() + "' where Nro_Matricula = '" + dtp.get_Nro_Matricula() + "'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

        public DataTable Listar_profesores()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Profesor";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listar_tipoensenanza()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Tipoensenanza";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listar_grado()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_grado";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listar_curso()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_curso";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }
    }
}
