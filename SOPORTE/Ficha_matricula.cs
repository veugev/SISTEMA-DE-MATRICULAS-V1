using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1.SOPORTE
{
    public partial class Ficha_matricula : Form
    {
        public Ficha_matricula()
        {
            InitializeComponent();
        }

        private void Ficha_matricula_Load(object sender, EventArgs e)
        {

        }

        private void Abrir_form (object otroForm)
        {

            if (this.panel_contenedor2.Controls.Count > 0)
               this.panel_contenedor2.Controls.RemoveAt(0);

           Form fh = otroForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor2.Controls.Add(fh);
            this.panel_contenedor2.Tag = fh;
            fh.Show();
        }

        private void ingresarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_form(new Datos_Alumno());
        }

        private void datosDeLaMadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_form(new Datos_Madre());
        }

        private void datosDelPadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_form(new Datos_Padre());
        }

        private void datosDelApoderadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_form(new Datos_Apoderado());
        }

        private void datosDeMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_form(new Datos_Matricula());
        }

        private void panel_contenedor2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datosApoderadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void asignarApoderadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_form(new Lista_personas());
        }
    }
}
