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
    public partial class Administradores : Form
    {
        public Administradores()
        {
            InitializeComponent();
        }

        private void Administradores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo para abrir formulario dentro de otro 
            AbrirForm2(new AgregarUs());
        }

        private void Administradores_Load_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Llamar al metodo para abrir formulario dentro de otro
            AbrirForm2(new EliminarUsuario());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Llamar al metodo para abrir formulario dentro de otro
            AbrirForm2(new ModificarUsu());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //volver a formulario Agregar administradores
            Agregar_Administradores RegresarAgregar_Adm = new Agregar_Administradores();
            RegresarAgregar_Adm.Show();

            //cerrar formulario al abrir otro
            this.Hide();
        }

        //Metodo para abrir un formulario dentro de otro
        private void AbrirForm2(object formularioAgregarform2)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);

            Form fh = formularioAgregarform2 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();
        }
    }
    }

