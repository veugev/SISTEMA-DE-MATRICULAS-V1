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
    class Datos : BdConexion
    {
        SqlDataAdapter da;
        DataTable dt;
        
        
        public void Cargar_Administrativos(DataGridView dgv)
        {
           
            try
            {

                conectado();
                da = new SqlDataAdapter("select * from administradores",ccn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo mostrar datos: " + ex.ToString());
            }
        }

        public void Cargar_Directivos (DataGridView dgv)
        {

            try
            {

                conectado();
                da = new SqlDataAdapter("select * from directivos", ccn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar datos: " + ex.ToString());
            }
        }
    }
}
