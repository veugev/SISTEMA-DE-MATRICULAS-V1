using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class Listar_Apoderados : Form
    {
        public Listar_Apoderados()
        {
            InitializeComponent();
            //agregar imagen a botones
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
            button4.BackgroundImage = Properties.Resources.button_icon_png_20;

            //bloquear el maximizar y agrandar tamaño

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;


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
            dgv_Apoderados.DataSource = ObjpersSQL.Listar_Personas();

        }


        private void label1_Click(object sender, EventArgs e)
            {

            }


        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv_Apoderados.SelectedRows.Count > 0)
            {
                 Editar_Apoderado frm = new Editar_Apoderado();
                
                 frm.txt_rut_p.Text = dgv_Apoderados.CurrentRow.Cells[0].Value.ToString();
                 frm.txt_nombre_p.Text= dgv_Apoderados.CurrentRow.Cells[1].Value.ToString();
                 frm.cmb_nacionalidad.Text = dgv_Apoderados.CurrentRow.Cells[2].Value.ToString();
                 frm.txt_direccion_p.Text= dgv_Apoderados.CurrentRow.Cells[3].Value.ToString();
                 frm.cmb_comuna.Text= dgv_Apoderados.CurrentRow.Cells[4].Value.ToString();
                 frm.cmb_niveleduc.Text= dgv_Apoderados.CurrentRow.Cells[5].Value.ToString();
                 frm.txt_ocupacion.Text= dgv_Apoderados.CurrentRow.Cells[6].Value.ToString();
                 frm.txt_fono_p.Text= dgv_Apoderados.CurrentRow.Cells[7].Value.ToString();
                 frm.cmb_parentezco.Text= dgv_Apoderados.CurrentRow.Cells[8].Value.ToString();
                 frm.txt_mail.Text= dgv_Apoderados.CurrentRow.Cells[9].Value.ToString();
                 frm.cmb_estudiante.Text = dgv_Apoderados.CurrentRow.Cells[10].Value.ToString();

                frm.ShowDialog();

            }


        }
        

        private void dgv_Personas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button1.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //volver al color de imagen de inicio de boton al salir de encima
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Datos_Apoderado frm = new Datos_Apoderado();
            frm.ShowDialog();
        }
    }
}

