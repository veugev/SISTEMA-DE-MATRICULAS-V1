using System;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class Datos_Madre : Form
    {

        CLASES.MadreSQL Objmadresql = new CLASES.MadreSQL();
        CLASES.Dmadre Objdmadre = new CLASES.Dmadre();
        public Datos_Madre()
        {
            InitializeComponent();
            button4.BackgroundImage = Properties.Resources.Btn_Verde;
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
            
        }
        private void AgregarDir_Load(object sender, EventArgs e)
        {
            ListarComuna();
            ListarParentezco();
            ListarMadre();

        }

        public void ListarComuna()
        {
            CLASES.MadreSQL ObjmadreSQL = new CLASES.MadreSQL();
            cmb_comuna.DataSource = ObjmadreSQL.Listar_Comuna();
            cmb_comuna.DisplayMember = "Descripcion";
            cmb_comuna.ValueMember = "id_comuna";
        }

        public void ListarParentezco()
        {
            CLASES.MadreSQL ObjmadreSQL = new CLASES.MadreSQL();
            cmb_parentezco.DataSource = ObjmadreSQL.Listar_Parentezco();
            cmb_parentezco.DisplayMember = "Descripcion";
            cmb_parentezco.ValueMember = "id_parentezco";
        }

        
        #region
        private void button1_Click(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            string rut_p = txt_rut_p.Text;
            string nombre_p = txt_nombre_p.Text;
            string nacionalidad_p = cmb_nacionalidad.SelectedItem.ToString();
            string direccion_p = txt_direccion_p.Text;
            int comuna_p = Convert.ToInt32(cmb_comuna.SelectedValue.ToString());
            string nivel_educacional = cmb_niveleduc.SelectedItem.ToString();
            string ocupacion = txt_ocupacion.Text;
            string fono_p = txt_fono_p.Text;
            int parentezco = Convert.ToInt32(cmb_parentezco.SelectedValue.ToString());
            string mail = txt_mail.Text;
            

            //enviamos el valor de las variables a los metodos set de la clase Dadministradores

            Objdmadre.set_rut_ma(rut_p);
            Objdmadre.set_nombre_ma(nombre_p);
            Objdmadre.set_nacionalidad_ma(nacionalidad_p);
            Objdmadre.set_direccion_ma(direccion_p);
            Objdmadre.set_comuna_ma(comuna_p);
            Objdmadre.set_nivel_educacional_ma(nivel_educacional);
            Objdmadre.set_ocupacion_ma(ocupacion);
            Objdmadre.set_fono_ma(fono_p);
            Objdmadre.set_parentezco_ma(parentezco);
            Objdmadre.set_mail_ma(mail);
           

            if (txt_rut_p.Text != String.Empty &&
                txt_nombre_p.Text != String.Empty &&
                txt_direccion_p.Text != String.Empty &&
                txt_ocupacion.Text != String.Empty &&
                txt_fono_p.Text != String.Empty &&
                txt_mail.Text != String.Empty)
            {
                //invocar al metodo insertar
                Objmadresql.InsertarPadre(Objdmadre);

                //limpiar 
                txt_rut_p.Clear();
                txt_nombre_p.Clear();
                cmb_nacionalidad.SelectedIndex = -1;
                txt_direccion_p.Clear();
                cmb_comuna.SelectedIndex = -1;
                cmb_niveleduc.SelectedIndex = -1;
                txt_ocupacion.Clear();
                txt_fono_p.Clear();
                cmb_parentezco.SelectedIndex = -1;
                txt_mail.Clear();
                
                MessageBox.Show("Datos ingresados exitosamente");

                ListarMadre();
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        public void ListarMadre()
        {
            CLASES.MadreSQL ObjmadreSQL = new CLASES.MadreSQL();
            dgv_Madres.DataSource = ObjmadreSQL.Listar_Madres();

        }

        #region
        private void label1_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }



            private void combobox_tipo_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }

            private void label8_Click(object sender, EventArgs e)
            {

            }

            private void label9_Click(object sender, EventArgs e)
            {

            }


            private void label11_Click(object sender, EventArgs e)
            {

            }

            private void label12_Click(object sender, EventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            string rut_p = txt_rut_p.Text;
            string nombre_p = txt_nombre_p.Text;
            string nacionalidad_p = cmb_nacionalidad.SelectedItem.ToString();
            string direccion_p = txt_direccion_p.Text;
            int comuna_p = Convert.ToInt32(cmb_comuna.SelectedValue.ToString());
            string nivel_educacional = cmb_niveleduc.SelectedItem.ToString();
            string ocupacion = txt_ocupacion.Text;
            string fono_p = txt_fono_p.Text;
            int parentezco = Convert.ToInt32(cmb_parentezco.SelectedValue.ToString());
            string mail = txt_mail.Text;

            //enviamos el valor de las variables a los metodos set de la clase Dadministradores

            Objdmadre.set_rut_ma(rut_p);
            Objdmadre.set_nombre_ma(nombre_p);
            Objdmadre.set_nacionalidad_ma(nacionalidad_p);
            Objdmadre.set_direccion_ma(direccion_p);
            Objdmadre.set_comuna_ma(comuna_p);
            Objdmadre.set_nivel_educacional_ma(nivel_educacional);
            Objdmadre.set_ocupacion_ma(ocupacion);
            Objdmadre.set_fono_ma(fono_p);
            Objdmadre.set_parentezco_ma(parentezco);
            Objdmadre.set_mail_ma(mail);
          
       

            if (txt_rut_p.Text != String.Empty &&
                txt_nombre_p.Text != String.Empty &&
                txt_direccion_p.Text != String.Empty &&
                txt_ocupacion.Text != String.Empty &&
                txt_fono_p.Text != String.Empty &&
                txt_mail.Text != String.Empty)
            {
                //invocar al metodo insertar
                Objmadresql.Modificarmadre(Objdmadre);

                //limpiar 
                txt_rut_p.Clear();
                txt_nombre_p.Clear();
                cmb_nacionalidad.SelectedIndex = -1;
                txt_direccion_p.Clear();
                cmb_comuna.SelectedIndex = -1;
                cmb_niveleduc.SelectedIndex = -1;
                txt_ocupacion.Clear();
                txt_fono_p.Clear();
                cmb_parentezco.SelectedIndex = -1;
                txt_mail.Clear();
               
                

                MessageBox.Show("Datos ingresados exitosamente");

                ListarMadre();
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv_Madres.SelectedRows.Count > 0)
            {
                txt_rut_p.Text = dgv_Madres.CurrentRow.Cells[0].Value.ToString();
                txt_nombre_p.Text = dgv_Madres.CurrentRow.Cells[1].Value.ToString();
                cmb_nacionalidad.Text = dgv_Madres.CurrentRow.Cells[2].Value.ToString();
                txt_direccion_p.Text = dgv_Madres.CurrentRow.Cells[3].Value.ToString();
                cmb_comuna.Text = dgv_Madres.CurrentRow.Cells[4].Value.ToString();
                cmb_niveleduc.Text = dgv_Madres.CurrentRow.Cells[5].Value.ToString();
                txt_ocupacion.Text = dgv_Madres.CurrentRow.Cells[6].Value.ToString();
                txt_fono_p.Text = dgv_Madres.CurrentRow.Cells[7].Value.ToString();
                cmb_parentezco.Text = dgv_Madres.CurrentRow.Cells[8].Value.ToString();
                txt_mail.Text = dgv_Madres.CurrentRow.Cells[9].Value.ToString();
   
            }
        }

        private void dgv_Madres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

