using System;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class Datos_Padre : Form
    {

        CLASES.PadreSQL Objpadresql = new CLASES.PadreSQL();
        CLASES.Dpadre Objdpadre = new CLASES.Dpadre();
        public Datos_Padre()
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
            ListarPadre();

        }

        public void ListarComuna()
        {
            CLASES.PadreSQL ObjpadreSQL = new CLASES.PadreSQL();
            cmb_comuna.DataSource = ObjpadreSQL.Listar_Comuna();
            cmb_comuna.DisplayMember = "Descripcion";
            cmb_comuna.ValueMember = "id_comuna";
        }

        public void ListarParentezco()
        {
            CLASES.PadreSQL ObjpadreSQL = new CLASES.PadreSQL();
            cmb_parentezco.DataSource = ObjpadreSQL.Listar_Parentezco();
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

            Objdpadre.set_rut_pa(rut_p);
            Objdpadre.set_nombre_pa(nombre_p);
            Objdpadre.set_nacionalidad_pa(nacionalidad_p);
            Objdpadre.set_direccion_pa(direccion_p);
            Objdpadre.set_comuna_pa(comuna_p);
            Objdpadre.set_nivel_educacional_pa(nivel_educacional);
            Objdpadre.set_ocupacion_pa(ocupacion);
            Objdpadre.set_fono_pa(fono_p);
            Objdpadre.set_parentezco_pa(parentezco);
            Objdpadre.set_mail_pa(mail);
           

            if (txt_rut_p.Text != String.Empty &&
                txt_nombre_p.Text != String.Empty &&
                txt_direccion_p.Text != String.Empty &&
                txt_ocupacion.Text != String.Empty &&
                txt_fono_p.Text != String.Empty &&
                txt_mail.Text != String.Empty)
            {
                //invocar al metodo insertar
                Objpadresql.InsertarPadre(Objdpadre);

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

                ListarPadre();
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        public void ListarPadre()
        {
            CLASES.PadreSQL ObjpadreSQL = new CLASES.PadreSQL();
            dgv_Padres.DataSource = ObjpadreSQL.Listar_Padres();

        }


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

            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void label11_Click(object sender, EventArgs e)
            {

            }

            private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
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

            Objdpadre.set_rut_pa(rut_p);
            Objdpadre.set_nombre_pa(nombre_p);
            Objdpadre.set_nacionalidad_pa(nacionalidad_p);
            Objdpadre.set_direccion_pa(direccion_p);
            Objdpadre.set_comuna_pa(comuna_p);
            Objdpadre.set_nivel_educacional_pa(nivel_educacional);
            Objdpadre.set_ocupacion_pa(ocupacion);
            Objdpadre.set_fono_pa(fono_p);
            Objdpadre.set_parentezco_pa(parentezco);
            Objdpadre.set_mail_pa(mail);
          
       

            if (txt_rut_p.Text != String.Empty &&
                txt_nombre_p.Text != String.Empty &&
                txt_direccion_p.Text != String.Empty &&
                txt_ocupacion.Text != String.Empty &&
                txt_fono_p.Text != String.Empty &&
                txt_mail.Text != String.Empty)
            {
                //invocar al metodo insertar
                Objpadresql.Modificarpadre(Objdpadre);

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

                ListarPadre();
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv_Padres.SelectedRows.Count > 0)
            {
                txt_rut_p.Text = dgv_Padres.CurrentRow.Cells[0].Value.ToString();
                txt_nombre_p.Text = dgv_Padres.CurrentRow.Cells[1].Value.ToString();
                cmb_nacionalidad.Text = dgv_Padres.CurrentRow.Cells[2].Value.ToString();
                txt_direccion_p.Text = dgv_Padres.CurrentRow.Cells[3].Value.ToString();
                cmb_comuna.Text = dgv_Padres.CurrentRow.Cells[4].Value.ToString();
                cmb_niveleduc.Text = dgv_Padres.CurrentRow.Cells[5].Value.ToString();
                txt_ocupacion.Text = dgv_Padres.CurrentRow.Cells[6].Value.ToString();
                txt_fono_p.Text = dgv_Padres.CurrentRow.Cells[7].Value.ToString();
                cmb_parentezco.Text = dgv_Padres.CurrentRow.Cells[8].Value.ToString();
                txt_mail.Text = dgv_Padres.CurrentRow.Cells[9].Value.ToString();
   
            }
        }

      
    }
}

