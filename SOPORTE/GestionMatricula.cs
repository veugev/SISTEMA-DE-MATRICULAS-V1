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
    public partial class GestionMatricula : Form
    {
        public GestionMatricula()
        {
            InitializeComponent();
        }

        private void Administradores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void AbrirAgregarUs(object formularioAgregarUs)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);

            Form fh = formularioAgregarUs as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();

            
            }

        private void panel_contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionMatricula_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirAgregarUs(new SOPORTE.Ficha_matricula());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //volver a formulario Agregar administradores
            Agregar_Administradores RegresarAgregar_Adm = new Agregar_Administradores();
            RegresarAgregar_Adm.Show();

            //cerrar formulario al abrir otro
            this.Hide();
        }
    }
    }

