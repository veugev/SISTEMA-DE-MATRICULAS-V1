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
    public partial class Perfil_Directivo : Form
    {
        public Perfil_Directivo()
        {
            InitializeComponent();
            
          
            button2.BackgroundImage = Properties.Resources.Btn_Celeste;
            button3.BackgroundImage = Properties.Resources.Btn_Celeste;
            button4.BackgroundImage = Properties.Resources.Btn_Celeste;
         

            this.MaximizeBox = false;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void Perfil_Soporte_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.Btn_Verde;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.Btn_Celeste;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.Btn_Verde;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.Btn_Celeste;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.Btn_Verde;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.Btn_Celeste;
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
            Administradores entrarAgregarUs = new Administradores();
            entrarAgregarUs.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Directivo_FormClosed(object sender, FormClosedEventArgs e)
        {
            //cerrar aplicacion

            Application.Exit();
        }
    }
}
