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
    class AdminSQL
    {
        
        private BdConexion Conexion = new BdConexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public void InsertarAdmin(Dadministradores dts)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Registrar_usuario";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@idus", dts.get_rut());
            Comando.Parameters.AddWithValue("@nom", dts.get_nombre());
            Comando.Parameters.AddWithValue("@usua", dts.get_usuario());
            Comando.Parameters.AddWithValue("@passw", dts.get_password());
            Comando.Parameters.AddWithValue("@tipoUs", dts.get_tipoUsuario());
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

        public int Persona_registrada(Dadministradores dts)
        {
            int contador = 0;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                //SqlCommand cmd = new SqlCommand("validar_existente");
                Comando.CommandText = "validar_existente";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@ids", dts.get_rut());
                Comando.ExecuteNonQuery();
                LeerFilas = Comando.ExecuteReader();
                while (LeerFilas.Read())
                {
                    contador++;
                }
                LeerFilas.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo consultar " + ex.ToString());
            }
            return contador;
        }

        public DataTable Listar_administradores()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Administradores";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void Insertar_admi()
        {

        }

    }

}
