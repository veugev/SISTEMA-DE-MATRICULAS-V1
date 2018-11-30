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

        public DataTable Listar_Estudiantes()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Estudiantes";
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

        public DataTable Listar_EstadoApod()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_EstadoApod";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void ModificarEstud(Destudiantes dts)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Update Estudiantes  set Nombre_Estudiante = '" + dts.get_nombre_e() + "', id_genero ='" + dts.get_genero_e() + "'," +
                                                            "Direccion ='" + dts.get_direccion_e() + "', id_comuna ='" + dts.get_comuna_e() + "', Fono_EmergenciaA ='" + dts.get_fonoA() + "'," +
                                                            "Fono_EmergenciaB ='" + dts.get_fonoB() + "', Fecha_Nacimiento ='" + dts.get_fnac_e() + "', Edad_Marzo ='" + dts.get_edadmarzo_e() + "'," +
                                                            "Nacionalidad_E ='" + dts.get_nacionalidad_e() + "', Establecimiento_Proc = '" + dts.get_estproc_e() + "', repitencia = '" + dts.get_repit_e() + "'," +
                                                            "curso_repetido ='" + dts.get_curepit_e() + "', id_salida ='" + dts.get_salida_e() + "', id_beneficio ='" + dts.get_benef_e() + "'," +
                                                            "NEE ='" + dts.get_nee() + "', id_vivecon ='" + dts.get_vivecon_e() + "'where Rut_id ='"+dts.get_rut_e()+"'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }


    }
}
