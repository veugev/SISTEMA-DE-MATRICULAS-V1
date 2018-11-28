using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1.CLASES
{
    class EstudiantesSQL
    {
        private BdConexion Conexion = new BdConexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable Listar_Genero()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Genero";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

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

        public DataTable Listar_SalidaEst()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_SalidaEstablecimiento";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listar_Vivecon()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Vivecon";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listar_Beneficio()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Beneficio";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void InsertarEstud(Destudiantes dts)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insert into Estudiantes values('" + dts.get_rut_e() + "','" + dts.get_nombre_e() + "','" + dts.get_genero_e() + "'," +
                                                            "'" + dts.get_direccion_e() + "','" + dts.get_comuna_e() + "','" + dts.get_fonoA() + "'," +
                                                            "'" + dts.get_fonoB() + "','" + dts.get_fnac_e() + "','" + dts.get_edadmarzo_e() + "'," +
                                                            "'" + dts.get_nacionalidad_e() + "','" + dts.get_estproc_e() + "','" + dts.get_repit_e() + "'," +
                                                            "'" + dts.get_curepit_e() + "','" + dts.get_salida_e() + "','" + dts.get_benef_e() + "'," +
                                                            "'" + dts.get_nee() + "','" + dts.get_vivecon_e() + "')";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }
       /* public void Insertar_Estudiante (Destudiantes dte)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Insertar_Alummo";
            Comando.Parameters.AddWithValue("@Rut_id", dte.get_rut_e());
            Comando.Parameters.AddWithValue("@Nombre_Estudiante", dte.get_nombre_e());
            Comando.Parameters.AddWithValue("@id_genero", dte.get_genero_e());
            Comando.Parameters.AddWithValue("@Direccion", dte.get_direccion_e());
            Comando.Parameters.AddWithValue("@id_comuna", dte.get_comuna_e());
            Comando.Parameters.AddWithValue("@Fono_EmergenciaA", dte.get_fonoA());
            Comando.Parameters.AddWithValue("@Fono_EmergenciaB", dte.get_fonoB());
            Comando.Parameters.AddWithValue("@Fecha_Nacimiento", dte.get_fnac_e());
            Comando.Parameters.AddWithValue("@Edad_Marzo", dte.get_edadmarzo_e());
            Comando.Parameters.AddWithValue("@Nacionalidad_E", dte.get_nacionalidad_e());
            Comando.Parameters.AddWithValue("@Establecimiento_Proc", dte.get_estproc_e());
            Comando.Parameters.AddWithValue("@repitencia", dte.get_repit_e());
            Comando.Parameters.AddWithValue("@curso_repetido", dte.get_curepit_e());
            Comando.Parameters.AddWithValue("@id_salida", dte.get_salida_e());
            Comando.Parameters.AddWithValue("@id_beneficio", dte.get_benef_e());
            Comando.Parameters.AddWithValue("@NEE", dte.get_nee());
            Comando.Parameters.AddWithValue("@id_vivecon", dte.get_vivecon_e());
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }*/
    }
}
