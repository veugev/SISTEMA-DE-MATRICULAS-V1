using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SISTEMA_DE_MATRICULA_V1.CLASES
{
    class ValidarAdm : BdConexion
    {
        public BdConexion Conexion = new BdConexion();
        public SqlCommand Comando = new SqlCommand();
        public SqlDataReader LeerFilas;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataTable validar_administradores(Dadministradores dts)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                //Comando = new SqlCommand("Validar_usuario");
                Comando.CommandText = "Validar_usuario";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@usu", dts.get_usuario());
                Comando.Parameters.AddWithValue("@pass", dts.get_password());

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(Comando);

                da.Fill(dt);
                return dt;
            }
            catch(Exception e)
            {
                throw(e);
            }
        }
    }
}
