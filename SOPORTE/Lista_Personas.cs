using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class Lista_personas : Form
    {
        public Lista_personas()
        {
            InitializeComponent();

            button4.BackgroundImage = Properties.Resources.button_icon_png_20;

        }

        private void AgregarDir_Load(object sender, EventArgs e)
        {
            ListarPerson();

        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }
      
       

        public void ListarPerson()
        {
            PersonasSQL ObjpersSQL = new PersonasSQL();
            dgv_Personas.DataSource = ObjpersSQL.Listar_Padres_madres();

        }


        private void label1_Click(object sender, EventArgs e)
            {

            }


        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv_Personas.SelectedRows.Count > 0)
            {
                Datos_Apoderado frm = new Datos_Apoderado();
                
                 frm.txt_rut_p.Text = dgv_Personas.CurrentRow.Cells[0].Value.ToString();
                 frm.txt_nombre_p.Text= dgv_Personas.CurrentRow.Cells[1].Value.ToString();
                 frm.cmb_nacionalidad.Text = dgv_Personas.CurrentRow.Cells[2].Value.ToString();
                 frm.txt_direccion_p.Text= dgv_Personas.CurrentRow.Cells[3].Value.ToString();
                 frm.cmb_comuna.Text= dgv_Personas.CurrentRow.Cells[4].Value.ToString();
                 frm.cmb_niveleduc.Text= dgv_Personas.CurrentRow.Cells[5].Value.ToString();
                 frm.txt_ocupacion.Text= dgv_Personas.CurrentRow.Cells[6].Value.ToString();
                 frm.txt_fono_p.Text= dgv_Personas.CurrentRow.Cells[7].Value.ToString();
                 frm.cmb_parentezco.Text= dgv_Personas.CurrentRow.Cells[8].Value.ToString();
                 frm.txt_mail.Text= dgv_Personas.CurrentRow.Cells[9].Value.ToString();

                frm.ShowDialog();

            }


        }
        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar imagen de boton al pasar por arriba
            button4.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            //volver al a imagen de inicio de boton al salir de encima
            button4.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        private void dgv_Personas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

