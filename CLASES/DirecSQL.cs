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
    class DirecSQL
    {
        private BdConexion Conexion = new BdConexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public void InsertarAdmin(Ddirectivos dts)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insert into Directivos values('" + dts.get_nick() + "','" + dts.get_nombre() + "'," +
                                   "'" + dts.get_usuario() + "','" + dts.get_contras() + "')";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }
        
        public DataTable Listar_Directivos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Directivos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void Modificar_direc(Ddirectivos dts)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "update Directivos set nombre_dir = '" + dts.get_nombre() + "', usuario_dir = '" + dts.get_usuario() + "', contrasena_dir = '" + dts.get_contras() + "' where id_directivos = '" + dts.get_nick() + "'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();


        }

        public void Eliminar_admin(Ddirectivos dts)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "delete Directivos where id_directivos = '" + dts.get_nick() + "'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();


        }
    }

}
