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
    public partial class Perfil_Soporte : Form
    {
        public Perfil_Soporte()
        {
            InitializeComponent();
            
            button1.BackgroundImage = Properties.Resources.Btn_Celeste;
            button2.BackgroundImage = Properties.Resources.Btn_Celeste;
            button3.BackgroundImage = Properties.Resources.Btn_Celeste;
            button4.BackgroundImage = Properties.Resources.Btn_Celeste;
            button5.BackgroundImage = Properties.Resources.Btn_Celeste;

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void Perfil_Soporte_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ir a formulario Agregar Administradores

            Agregar_Administradores entrarAgregarAdm = new Agregar_Administradores();
            entrarAgregarAdm.Show();


            //ocultar formulario al abrir otro
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button1.BackgroundImage = Properties.Resources.Btn_Verde;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //volver al color e imagen de inicio de boton al salir de encima
            button1.BackgroundImage = Properties.Resources.Btn_Celeste;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button2.BackgroundImage = Properties.Resources.Btn_Verde;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            //volver al color e imagen de inicio de boton al salir de encima
            button2.BackgroundImage = Properties.Resources.Btn_Celeste;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button3.BackgroundImage = Properties.Resources.Btn_Verde;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            //volver al color e imagen de inicio de boton al salir de encima
            button3.BackgroundImage = Properties.Resources.Btn_Celeste;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button4.BackgroundImage = Properties.Resources.Btn_Verde;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            //volver al color e imagen de inicio de boton al salir de encima
            button4.BackgroundImage = Properties.Resources.Btn_Celeste;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button5.BackgroundImage = Properties.Resources.Btn_Verde;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            //volver al color e imagen de inicio de boton al salir de encima
            button5.BackgroundImage = Properties.Resources.Btn_Celeste;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Soporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            //cerrar aplicacion
            Application.Exit();
        }
    }
}
