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
    public partial class Mantencion_Datos : Form
    {
        public Mantencion_Datos()
        {
            InitializeComponent();
        }

        private void Ficha_matricula_Load(object sender, EventArgs e)
        {

        }

        private void Abrir_form (object otroForm)
        {

            if (this.panel_contenedor3.Controls.Count > 0)
               this.panel_contenedor3.Controls.RemoveAt(0);

           Form fh = otroForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor3.Controls.Add(fh);
            this.panel_contenedor3.Tag = fh;
            fh.Show();
        }
            
        private void ingresarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_form(new Agregar_Anio());
        }

        private void datosDeLaMadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void datosDelPadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void datosDelApoderadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void datosDeMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_form(new Agregar_Comunas());
        }

        private void panel_contenedor2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datosFamiliaresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
