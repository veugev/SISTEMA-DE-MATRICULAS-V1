using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
	
namespace SISTEMA_DE_MATRICULA_V1
{
    class BdConexion
    {
        public SqlConnection ccn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public void conectado()
        {
            ccn = new SqlConnection("server=DESKTOP-CM1ROJC\\EXPRESS2014 ; database=matricula ; integrated security = true");
            ccn.Open();

        }
    }
}
