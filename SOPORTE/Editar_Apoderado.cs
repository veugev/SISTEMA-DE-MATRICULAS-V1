using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class Editar_Apoderado : Form
    {

        PersonasSQL Objpersonasql = new PersonasSQL();
        Dpersonas Objdpers = new Dpersonas();
        
        private BdConexion Conexion = new BdConexion();
        private SqlCommand Comando = new SqlCommand();

        

        public Editar_Apoderado()
        {
            InitializeComponent();
            button4.BackgroundImage = Properties.Resources.Btn_Verde;
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
         

        }
        private void AgregarDir_Load(object sender, EventArgs e)
        {
            ListarComuna();
            ListarEstudiante();
            ListarParentezco();
        

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
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
        }

       


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                 
        }

        #region
        private void label1_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
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
            string rut_e = cmb_estudiante.SelectedValue.ToString();

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
       

            if (txt_rut_p.Text != String.Empty &&
                txt_nombre_p.Text != String.Empty &&
                txt_direccion_p.Text != String.Empty &&
                txt_ocupacion.Text != String.Empty &&
                txt_fono_p.Text != String.Empty &&
                txt_mail.Text != String.Empty)
            {
                //invocar al metodo insertar
                Objpersonasql.Modificarpers(Objdpers);

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
                cmb_estudiante.SelectedIndex = -1;
                

                MessageBox.Show("Datos ingresados exitosamente");

            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //declaramos variables que recibe valores que el usuario ingresa
            string rut = txt_rut_p.Text;


            //enviamos el valor de las variables a los metodos set de la clase Dadministradores
            Objdpers.set_rut_p(rut);



            if (txt_rut_p.Text != String.Empty &&
               txt_nombre_p.Text != String.Empty &&
               txt_direccion_p.Text != String.Empty &&
               txt_ocupacion.Text != String.Empty &&
               txt_fono_p.Text != String.Empty &&
               txt_mail.Text != String.Empty)
            {
                try
                {
                    //invocar al metodo insertar
                    Objpersonasql.Eliminarpers(Objdpers);

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
                    cmb_estudiante.SelectedIndex = -1;

                   

                    MessageBox.Show("El Usuario fue insertado exitosamente");

                }
                catch (SqlException)
                {
                    MessageBox.Show("El Usuario ya existe");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        private void cmb_estudiante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}

