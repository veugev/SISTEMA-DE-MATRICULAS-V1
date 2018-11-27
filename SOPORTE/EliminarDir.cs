using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class EliminarDir: Form
    {

        CLASES.DirecSQL Objdirectivosql = new CLASES.DirecSQL();
        CLASES.Ddirectivos Objddirect = new CLASES.Ddirectivos();
        public EliminarDir()
        {
            InitializeComponent();

            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //declaramos variables que recibe valores que el usuario ingresa
            string rut = txt_rutdirec.Text;
           

            //enviamos el valor de las variables a los metodos set de la clase Dadministradores
            Objddirect.set_nick(rut);
            


            if (txt_rutdirec.Text != String.Empty && txt_nombredir.Text != String.Empty && txt_usuariodir.Text != String.Empty && txt_passdir.Text != String.Empty)
            {
                try
                {
                    //invocar al metodo insertar
                    Objdirectivosql.Eliminar_admin(Objddirect);

                    //limpiar 
                    txt_rutdirec.Clear();
                    txt_nombredir.Clear();
                    txt_usuariodir.Clear();
                    txt_passdir.Clear();


                    ListarDir();

                    MessageBox.Show("El Usuario fue insertado exitosamente");

                }
                catch (SqlException)
                {
                    MessageBox.Show("El Usuario ya existe");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarDir_Load(object sender, EventArgs e)
        {
            ListarDir();
        }

        private void dgv_Directivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgv_Directivos.SelectedRows.Count > 0)
            {
                txt_rutdirec.Text = dgv_Directivos.CurrentRow.Cells[0].Value.ToString();
                txt_nombredir.Text = dgv_Directivos.CurrentRow.Cells[1].Value.ToString();
                txt_usuariodir.Text = dgv_Directivos.CurrentRow.Cells[2].Value.ToString();
                txt_passdir.Text = dgv_Directivos.CurrentRow.Cells[3].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
        public void ListarDir()
        {
            CLASES.DirecSQL ObjetdirSQL = new CLASES.DirecSQL();
            dgv_Directivos.DataSource = ObjetdirSQL.Listar_Directivos();

        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button1.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //volver al color de imagen de inicio de boton al salir de encima
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
        }


        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button2.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            //volver al color de imagen de inicio de boton al salir de encima
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
        }
    }
}
