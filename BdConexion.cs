using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
	
namespace SISTEMA_DE_MATRICULA_V1
{
    class BdConexion
    {
        private MySqlConnection conexion;
        private string servidor;
        private string baseDatos;
        private string usuario;
        private string password;
        public BdConexion()
        {
            establecerConfiguracion();
        }

        //Se configura la conexion al SGBD MySql, el constructor de la clase MySqlConnection establece la conexion de
        //acuerdo a los parametros establecidos.
        private void establecerConfiguracion()
        {
            servidor = "127.0.0.1";
            baseDatos = "matricula";
            usuario = "root";
            password = "";
            string cadenaConexion = "SERVER=" + servidor + ";" + "DATABASE=" + baseDatos + ";" + "UID=" + usuario + ";" + "PASSWORD=" + password + ";";
            conexion = new MySqlConnection(cadenaConexion);
        }

        public bool abrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        public bool cerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
    }
}
