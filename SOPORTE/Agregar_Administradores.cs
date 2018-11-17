using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class Agregar_Administradores: Form
    {
        public Agregar_Administradores()
        {
            InitializeComponent();

            //agregar imagen a botones
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;

            //bloquear el maximizar y agrandar tamaño

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            //ir a formulario Agregar Administradores

             Administradores entrarAgregarAdm = new  Administradores();
            entrarAgregarAdm.Show();


            //ocultar formulario al abrir otro
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //ir a formulario Agregar Directivos

            Directivos entrarDirectivos = new Directivos();
                entrarDirectivos.Show();


            //ocultar formulario al abrir otro
            this.Hide();
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
            //cambiar imagen de boton al pasar por arriba
            button2.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            //volver al a imagen de inicio de boton al salir de encima
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        private void Tipos_Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            //cerrar aplicacion
            Application.Exit();
        }

        private void Agregar_Administradores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //volver a formulario pricipal soporte
            Perfil_Soporte entrarSoporte = new Perfil_Soporte();
            entrarSoporte.Show();

            //cerrar formulario al abrir otro
            this.Hide();
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {

            //cambiar imagen al pasar por encima el mouse
            pictureBox7.Image = Properties.Resources.house_home_13944;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            //volver a imagen de inicio
            pictureBox7.Image = Properties.Resources.home_house_13984;
        }
    }
}


