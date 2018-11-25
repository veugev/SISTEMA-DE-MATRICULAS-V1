using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SISTEMA_DE_MATRICULA_V1.CLASES
{
    class ValidarDir : BdConexion
    {
        public BdConexion Conexion = new BdConexion();
        public SqlCommand Comando = new SqlCommand();
        public SqlDataReader LeerFilas;
        public SqlDataAdapter da;
        public DataTable dt;

        public DataTable validar_directivos(Ddirectivos dts)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando = new SqlCommand("Validar_directivos");

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@usua", dts.get_nick());
                Comando.Parameters.AddWithValue("@passw", dts.get_contras());

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(Comando);

                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

    }
}
