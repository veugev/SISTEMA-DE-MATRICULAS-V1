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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();

            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Directivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //volver a formulario Agregar administradores
            Agregar_Administradores RegresarAgregar_Adm = new Agregar_Administradores();
            RegresarAgregar_Adm.Show();

            //cerrar formulario al abrir otro
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
        }
    }
}
