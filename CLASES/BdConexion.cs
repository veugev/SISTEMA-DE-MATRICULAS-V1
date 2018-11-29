using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
	
namespace SISTEMA_DE_MATRICULA_V1
{
    class BdConexion
    {
        static public string CadenaConexion = "server=DESKTOP-J3LLPBF\\EXPRESS2014 ; database=BD_Matricula2 ; integrated security = true";
        public SqlConnection Conexion = new SqlConnection(CadenaConexion);    

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            
                Conexion.Open();
                return Conexion;
            
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
