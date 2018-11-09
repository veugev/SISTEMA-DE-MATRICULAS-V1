using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
	
namespace SISTEMA_DE_MATRICULA_V1
{
    public class BdConexion
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=matricula; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }
    }
}
