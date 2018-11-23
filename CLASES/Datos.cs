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
        SqlDataReader dr;
       
        
        
        
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

        public void Insertar_usuario(Dadministradores dts)
        {
            
            try
            {
                conectado();
                SqlCommand cmd = new SqlCommand("Registrar_usuario", ccn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idus", dts.get_rut());
                cmd.Parameters.AddWithValue("@nom", dts.get_nombre());
                cmd.Parameters.AddWithValue("@usua", dts.get_usuario());
                cmd.Parameters.AddWithValue("@passw", dts.get_password());
                cmd.Parameters.AddWithValue("@tipoUs", dts.get_tipoUsuario());

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                throw e;
                
            }
           
        }
        public  int Persona_registrada(Dadministradores dts)
        {
            int contador = 0;
            try
            {
                conectado();
                SqlCommand cmd = new SqlCommand("validar_existente", ccn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ids", dts.get_rut());
                
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    contador++;
                }
            }catch (Exception ex)
            {
                MessageBox.Show("no se pudo consultar " + ex.ToString());
            }
            return contador;
        }

        public void buscar_registro(Dadministradores dts)
        {
            
            try
            {
                conectado();
                SqlCommand cmd = new SqlCommand("validar_existente", ccn);
                string rut = dts.get_rut();
                string nom = dts.get_nombre();
                string usu = dts.get_usuario();
                string pass = dts.get_password();
                string tipous = dts.get_tipoUsuario();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ids", rut);

                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    nom = dr["nombre"].ToString();
                    usu = dr["usuario"].ToString();
                    pass = dr["contrasena"].ToString();
                    tipous = dr["tipo_usuario"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar los campos " + ex.ToString());
            }
           
        }
    }
}
