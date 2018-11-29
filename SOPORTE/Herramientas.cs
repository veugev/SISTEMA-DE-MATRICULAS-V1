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
    public partial class Herramientas : Form
    {
        public Herramientas()
        {
            InitializeComponent();
        }

        private void Administradores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            AbrirMantencion_tablas(new());
        }

            private void AbrirMantencion_tablas(object formularioAgregar_Anio)
            {
                if (this.panel_contenedor.Controls.Count > 0)
                    this.panel_contenedor.Controls.RemoveAt(0);

                Form fh = formularioAgregar_Anio as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel_contenedor.Controls.Add(fh);
                this.panel_contenedor.Tag = fh;
                fh.Show();


            }
        
    }
}

