using System;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class Datos_Padre : Form
    {

        PersonasSQL Objpersonasql = new PersonasSQL();
        Dpersonas Objdpers = new Dpersonas();
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
            ListarEstado_Apod();
            ListarEstudiante();
            ListarParentezco();
            ListarPerson();

        }

        public void ListarComuna()
        {
            PersonasSQL ObjpersoSQL = new PersonasSQL();
            cmb_comuna.DataSource = ObjpersoSQL.Listar_Comuna();
            cmb_comuna.DisplayMember = "Descripcion";
            cmb_comuna.ValueMember = "id_comuna";
        }

        public void ListarParentezco()
        {
            PersonasSQL ObjpersoSQL = new PersonasSQL();
            cmb_parentezco.DataSource = ObjpersoSQL.Listar_Parentezco();
            cmb_parentezco.DisplayMember = "Descripcion";
            cmb_parentezco.ValueMember = "id_parentezco";
        }

        public void ListarEstado_Apod()
        {
            PersonasSQL ObjpersoSQL = new PersonasSQL();
            cmb_tipoa.DataSource = ObjpersoSQL.Listar_EstadoApod();
            cmb_tipoa.DisplayMember = "Descripcion";
            cmb_tipoa.ValueMember = "id_estadoapod";
        }

        public void ListarEstudiante()
        {
            PersonasSQL ObjpersoSQL = new PersonasSQL();
            cmb_estudiante.DataSource = ObjpersoSQL.Listar_Estudiantes();
            cmb_estudiante.DisplayMember = "Nombre_Estudiante";
            cmb_estudiante.ValueMember = "Rut_id";
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
            string nacionalidad_p = txt_nacionalidad_p.Text;
            string direccion_p = txt_direccion_p.Text;
            int comuna_p = Convert.ToInt32(cmb_comuna.SelectedValue.ToString());
            string nivel_educacional = txt_nivel_educ.Text;
            string ocupacion = txt_ocupacion.Text;
            string fono_p = txt_fono_p.Text;
            int parentezco = Convert.ToInt32(cmb_parentezco.SelectedValue.ToString());
            string mail = txt_mail.Text;
            string rut_e = cmb_estudiante.SelectedValue.ToString();
            int estado_apod = Convert.ToInt32(cmb_tipoa.SelectedValue.ToString());

            //enviamos el valor de las variables a los metodos set de la clase Dadministradores

            Objdpers.set_rut_p(rut_p);
            Objdpers.set_nombre_p(nombre_p);
            Objdpers.set_nacionalidad_p(nacionalidad_p);
            Objdpers.set_direccion_p(direccion_p);
            Objdpers.set_comuna_p(comuna_p);
            Objdpers.set_nivel_educacional(nivel_educacional);
            Objdpers.set_ocupacion(ocupacion);
            Objdpers.set_fono_p(fono_p);
            Objdpers.set_parentezco(parentezco);
            Objdpers.set_mail(mail);
            Objdpers.set_rut_e(rut_e);
            Objdpers.set_estado_apod(estado_apod);

            if (txt_rut_p.Text != String.Empty &&
                txt_nombre_p.Text != String.Empty &&
                txt_nacionalidad_p.Text != String.Empty &&
                txt_direccion_p.Text != String.Empty &&
                txt_nivel_educ.Text != String.Empty &&
                txt_ocupacion.Text != String.Empty &&
                txt_fono_p.Text != String.Empty &&
                txt_mail.Text != String.Empty)
            {
                //invocar al metodo insertar
                Objpersonasql.InsertarPers(Objdpers);

                //limpiar 
                txt_rut_p.Clear();
                txt_nombre_p.Clear();
                txt_nacionalidad_p.Clear();
                txt_direccion_p.Clear();
                cmb_comuna.SelectedIndex = -1;
                txt_nivel_educ.Clear();
                txt_ocupacion.Clear();
                txt_fono_p.Clear();
                cmb_parentezco.SelectedIndex = -1;
                txt_mail.Clear();
                cmb_estudiante.SelectedIndex = -1;
                cmb_tipoa.SelectedIndex = -1;

                MessageBox.Show("Datos ingresados exitosamente");

                ListarPerson();
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        public void ListarPerson()
        {
            PersonasSQL ObjpersSQL = new PersonasSQL();
            dgv_Personas.DataSource = ObjpersSQL.Listar_Personas();

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
            string nacionalidad_p = txt_nacionalidad_p.Text;
            string direccion_p = txt_direccion_p.Text;
            int comuna_p = Convert.ToInt32(cmb_comuna.SelectedValue.ToString());
            string nivel_educacional = txt_nivel_educ.Text;
            string ocupacion = txt_ocupacion.Text;
            string fono_p = txt_fono_p.Text;
            int parentezco = Convert.ToInt32(cmb_parentezco.SelectedValue.ToString());
            string mail = txt_mail.Text;
            string rut_e = cmb_estudiante.SelectedValue.ToString();
            int estado_apod = Convert.ToInt32(cmb_tipoa.SelectedValue.ToString());

            //enviamos el valor de las variables a los metodos set de la clase Dadministradores

            Objdpers.set_rut_p(rut_p);
            Objdpers.set_nombre_p(nombre_p);
            Objdpers.set_nacionalidad_p(nacionalidad_p);
            Objdpers.set_direccion_p(direccion_p);
            Objdpers.set_comuna_p(comuna_p);
            Objdpers.set_nivel_educacional(nivel_educacional);
            Objdpers.set_ocupacion(ocupacion);
            Objdpers.set_fono_p(fono_p);
            Objdpers.set_parentezco(parentezco);
            Objdpers.set_mail(mail);
            Objdpers.set_rut_e(rut_e);
            Objdpers.set_estado_apod(estado_apod);

            if (txt_rut_p.Text != String.Empty &&
                txt_nombre_p.Text != String.Empty &&
                txt_nacionalidad_p.Text != String.Empty &&
                txt_direccion_p.Text != String.Empty &&
                txt_nivel_educ.Text != String.Empty &&
                txt_ocupacion.Text != String.Empty &&
                txt_fono_p.Text != String.Empty &&
                txt_mail.Text != String.Empty)
            {
                //invocar al metodo insertar
                Objpersonasql.Modificarpers(Objdpers);

                //limpiar 
                txt_rut_p.Clear();
                txt_nombre_p.Clear();
                txt_nacionalidad_p.Clear();
                txt_direccion_p.Clear();
                cmb_comuna.SelectedIndex = -1;
                txt_nivel_educ.Clear();
                txt_ocupacion.Clear();
                txt_fono_p.Clear();
                cmb_parentezco.SelectedIndex = -1;
                txt_mail.Clear();
                cmb_estudiante.SelectedIndex = -1;
                cmb_tipoa.SelectedIndex = -1;

                MessageBox.Show("Datos ingresados exitosamente");

                ListarPerson();
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv_Personas.SelectedRows.Count > 0)
            {
                txt_rut_p.Text = dgv_Personas.CurrentRow.Cells[0].Value.ToString();
                txt_nombre_p.Text = dgv_Personas.CurrentRow.Cells[1].Value.ToString();
                txt_nacionalidad_p.Text = dgv_Personas.CurrentRow.Cells[2].Value.ToString();
                txt_direccion_p.Text = dgv_Personas.CurrentRow.Cells[3].Value.ToString();
                cmb_comuna.Text = dgv_Personas.CurrentRow.Cells[4].Value.ToString();
                txt_nivel_educ.Text = dgv_Personas.CurrentRow.Cells[5].Value.ToString();
                txt_ocupacion.Text = dgv_Personas.CurrentRow.Cells[6].Value.ToString();
                txt_fono_p.Text = dgv_Personas.CurrentRow.Cells[7].Value.ToString();
                cmb_parentezco.Text = dgv_Personas.CurrentRow.Cells[8].Value.ToString();
                txt_mail.Text = dgv_Personas.CurrentRow.Cells[9].Value.ToString();
                cmb_estudiante.Text = dgv_Personas.CurrentRow.Cells[10].Value.ToString();
                cmb_tipoa.Text = dgv_Personas.CurrentRow.Cells[11].Value.ToString();
                
            }
        }

        private void cmb_estudiante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

