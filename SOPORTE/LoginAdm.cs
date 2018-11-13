using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class LoginAdm : Form
    {
        public LoginAdm()
        {
            InitializeComponent();

            //agregar imagen a botones

            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
            button2.BackgroundImage = Properties.Resources.Btn_Rojo;

            //bloquear el maximizar y agrandar tamaño

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button1.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //volver al color e imagen de inicio de boton al salir de encima
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //ir a formulario login Administradores
            Perfil_Soporte entrarSoporte = new Perfil_Soporte();
            entrarSoporte.Show();

            //ocultar formulario al abrir otro
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
           Tipos_Usuario volverform = new Tipos_Usuario();
            volverform.Show();
            this.Close();

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.Btn_Naranjo;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.Btn_Rojo;
        }
    }
}
