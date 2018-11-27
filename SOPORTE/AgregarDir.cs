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
    public partial class AgregarDir: Form
    {

        CLASES.DirecSQL Objdirectivosql = new CLASES.DirecSQL();
        CLASES.Ddirectivos Objddirect = new CLASES.Ddirectivos();


        public AgregarDir()
        {
            InitializeComponent();
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
            
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
            string rut = txt_rutdir.Text;
            string nom = txt_nombredir.Text;
            string usadm = txt_usuariodir.Text;
            string pass = txt_passdir.Text;
            
            //enviamos el valor de las variables a los metodos set de la clase Dadministradores
            Objddirect.set_nick(rut);
            Objddirect.set_nombre(nom);
            Objddirect.set_usuario(usadm);
            Objddirect.set_contras(pass);
            

            if (txt_rutdir.Text != String.Empty && txt_nombredir.Text != String.Empty && txt_usuariodir.Text != String.Empty && txt_passdir.Text != String.Empty)
            {
                try
                {
                    //invocar al metodo insertar
                    Objdirectivosql.InsertarAdmin(Objddirect);

                    //limpiar 
                    txt_rutdir.Clear();
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
        public void ListarDir()
        {
            CLASES.DirecSQL ObjetdirSQL = new CLASES.DirecSQL();
            dgv_Directivos.DataSource = ObjetdirSQL.Listar_Directivos();

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
