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
    public partial class LoginDir : Form
    {
        public LoginDir()
        {
            InitializeComponent();
            //Poner imagen de inicio a los botones
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
            button2.BackgroundImage = Properties.Resources.Btn_Rojo;

            //quitar botones de maximizar, minimizar y cerrar
            this.MaximizeBox = false;

            this.ControlBox = false;

            //bloquear el tamaño del formulario
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoginDir_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginAdm cambiarform = new LoginAdm();
            cambiarform.Show();
            this.Hide();
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
