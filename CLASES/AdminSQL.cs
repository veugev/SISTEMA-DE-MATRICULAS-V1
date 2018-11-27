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
            Comando.CommandText = "insert into Administradores values('" + dts.get_rut()+"','" + dts.get_nombre()+"','" + dts.get_usuario()+ "','" + dts.get_password()+ "','" + dts.get_tipoUsuario()+ "')";
            Comando.CommandType = CommandType.Text;
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

        public void Modificar_admin(Dadministradores dts)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "update Administradores set nombre = '"+dts.get_nombre()+"', usuario = '"+dts.get_usuario()+"', contrasena = '"+dts.get_password()+"', tipo_usuario = '"+dts.get_tipoUsuario()+"'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();


        }


    }

}
