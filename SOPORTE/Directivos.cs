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
    public partial class Directivos: Form
    {
        public Directivos()
        {
            InitializeComponent();
        }

        private void Administradores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo para abrir formulario dentro de otro 
            AbrirForm(new AgregarDir());
        }

        //Metodo para abrir un formulario dentro de otro
        private void AbrirForm(object formularioAgregarform)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);

            Form fh = formularioAgregarform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();

            
            }

        private void Administradores_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Llamar al metodo para abrir formulario dentro de otro
            AbrirForm(new ModificarDir());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Llamar al metodo para abrir formulario dentro de otro
            AbrirForm(new EliminarDir());
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

