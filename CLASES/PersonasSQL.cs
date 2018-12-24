using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1
{
    class PersonasSQL
    {
        private BdConexion Conexion = new BdConexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        CLASES.Dmadre dm = new CLASES.Dmadre();

        
        
        public DataTable Listar_Comuna()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Comuna";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void InsertarPers(Dpersonas dtp)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insert into Personas values('" + dtp.get_rut_p() + "','" + dtp.get_nombre_p() + "','" + dtp.get_nacionalidad_p() + "'," +
                                                            "'" + dtp.get_direccion_p() + "','" + dtp.get_comuna_p() + "','" + dtp.get_nivel_educacional() + "'," +
                                                            "'" + dtp.get_ocupacion() + "','" + dtp.get_fono_p() + "','" + dtp.get_parentezco() + "'," +
                                                            "'" + dtp.get_mail() + "','" + dtp.get_rut_e() + "')";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

        public DataTable Listar_Personas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Personas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listar_Parentezco()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_parentezco";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void Modificarpers(Dpersonas dtp)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Update Personas  set Nombre_persona = '" + dtp.get_nombre_p() + "', Nacionalidad_P= '" + dtp.get_nacionalidad_p() + "'," +
                                                            "Direccion = '" + dtp.get_direccion_p() + "', id_comuna = '" + dtp.get_comuna_p() + "', Nivel_educ = '" + dtp.get_nivel_educacional() + "'," +
                                                            " Ocupacion = '" + dtp.get_ocupacion() + "', Fono ='" + dtp.get_fono_p() + "', id_parentezco = '" + dtp.get_parentezco() + "'," +
                                                            "Mail = '" + dtp.get_mail() + "', Rut_id = '" + dtp.get_rut_e() + "'where id_Rut = '" + dtp.get_rut_p() + "'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

        public DataTable Listar_Estudiantes()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_alumno";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listar_Padres_madres()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Apoderados";
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
