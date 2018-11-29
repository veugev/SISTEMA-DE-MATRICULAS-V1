using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class Datos_Alumno : Form
    {

        CLASES.EstudiantesSQL Objestudiantesql = new CLASES.EstudiantesSQL();
        CLASES.Destudiantes Objdestud = new CLASES.Destudiantes();
        public Datos_Alumno()
        {
            InitializeComponent();

            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
            button1.BackgroundImage = Properties.Resources.Btn_Verde;

        }

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
            //declaramos variables que recibe valores que el usuario ingresa
            string rut_e = txt_edad_e.Text;
            string nombre_e = txt_edad_e.Text;
            int genero_e = Convert.ToInt32(cmb_genero.SelectedValue.ToString());
            string direccion_e = txt_edad_e.Text;
            int comuna_e = Convert.ToInt32(cmb_comuna.SelectedValue.ToString());
            string fonoA = txt_edad_e.Text;
            string fonoB = txt_edad_e.Text;
            string fnac_e = dtp_Fnac_e.Text;
            string edadmarzo_e = txt_edad_e.Text;
            string nacionalidad_e = txt_edad_e.Text;
            string estproc_e = txt_edad_e.Text;
            string repit_e = txt_edad_e.Text;
            string currepit_e = txt_edad_e.Text;
            int salida_e = Convert.ToInt32(cmb_salida.SelectedValue.ToString());
            int benef_e = Convert.ToInt32(cmb_beneficio.SelectedValue.ToString());
            string nee = txt_edad_e.Text;
            int vivecon_e = Convert.ToInt32(cmb_vivecon.SelectedValue.ToString());

            //enviamos el valor de las variables a los metodos set de la clase Dadministradores
            Objdestud.set_rut_e(rut_e);
            Objdestud.set_nombre_e(nombre_e);
            Objdestud.set_genero_e(genero_e);
            Objdestud.set_direccion_e(direccion_e);
            Objdestud.set_comuna_e(comuna_e);
            Objdestud.set_fonoA(fonoA);
            Objdestud.set_fonoB(fonoB);
            Objdestud.set_fnac_e(fnac_e);
            Objdestud.set_edadmarzo_e(edadmarzo_e);
            Objdestud.set_nacionalidad_e(nacionalidad_e);
            Objdestud.set_estproc_e(estproc_e);
            Objdestud.set_repit_e(repit_e);
            Objdestud.set_currepit_e(currepit_e);
            Objdestud.set_salida_e(salida_e);
            Objdestud.set_benef_e(benef_e);
            Objdestud.set_nee(nee);
            Objdestud.set_vivecon_e(vivecon_e);


            /*if (txt_rut_e.Text != String.Empty && cmb_genero.SelectedItem.ToString() != String.Empty &&
                txt_nombre_e.Text != String.Empty && dtp_Fnac_e.Text != String.Empty && txt_edad_e.Text != String.Empty &&
                txt_nacionalidad_e.Text != String.Empty && cmb_comuna.SelectedItem.ToString() != String.Empty && 
                txt_direccion_e.Text != String.Empty && cmb_salida.SelectedItem.ToString() != String.Empty && 
                cmb_vivecon.SelectedItem.ToString() != String.Empty && txt_fonoa.Text != String.Empty && txt_fonob.Text != String.Empty &&
                txt_proc_e.Text != String.Empty && cmb_repitencia.SelectedItem.ToString() != String.Empty && txt_currepit_e.Text != String.Empty && 
                cmb_beneficio.SelectedItem.ToString() != String.Empty)
            {*/

            //invocar al metodo insertar
            Objestudiantesql.InsertarEstud(Objdestud);

            //limpiar 
            txt_rut_e.Clear();
            cmb_genero.SelectedIndex = -1;
            txt_nombre_e.Clear();
            txt_edad_e.Clear();
            txt_nacionalidad_e.Clear();
            cmb_comuna.SelectedIndex = -1;
            txt_direccion_e.Clear();
            cmb_salida.SelectedIndex = -1;
            cmb_vivecon.SelectedIndex = -1;
            txt_fonoa.Clear();
            txt_fonob.Clear();
            txt_proc_e.Clear();
            cmb_repitencia.SelectedIndex = -1;
            txt_currepit_e.Clear();
            cmb_beneficio.SelectedIndex = -1;

            MessageBox.Show("Datos ingresados exitosamente");


            /* }
             else
             {
                 MessageBox.Show("Debe ingresar todos los datos");
             }*/
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

        private void AgregarDir_Load(object sender, EventArgs e)
        {

            ListarGenero();
            ListarComuna();
            ListarSalida();
            ListarVivecon();
            ListarBeneficio();



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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        public void ListarGenero()
        {
            CLASES.EstudiantesSQL ObjetestSQL = new CLASES.EstudiantesSQL();
            cmb_genero.DataSource = ObjetestSQL.Listar_Genero();
            cmb_genero.DisplayMember = "Descripcion";
            cmb_genero.ValueMember = "id_genero";

        }

        public void ListarComuna()
        {
            CLASES.EstudiantesSQL ObjetestSQL = new CLASES.EstudiantesSQL();
            cmb_comuna.DataSource = ObjetestSQL.Listar_Comuna();
            cmb_comuna.DisplayMember = "Descripcion";
            cmb_comuna.ValueMember = "id_comuna";

        }

        public void ListarSalida()
        {
            CLASES.EstudiantesSQL ObjetestSQL = new CLASES.EstudiantesSQL();
            cmb_salida.DataSource = ObjetestSQL.Listar_SalidaEst();
            cmb_salida.DisplayMember = "Descripcion";
            cmb_salida.ValueMember = "id_salida";

        }


        public void ListarVivecon()
        {
            CLASES.EstudiantesSQL ObjetestSQL = new CLASES.EstudiantesSQL();
            cmb_vivecon.DataSource = ObjetestSQL.Listar_Vivecon();
            cmb_vivecon.DisplayMember = "Descripcion";
            cmb_vivecon.ValueMember = "id_vivecon";

        }

        public void ListarBeneficio()
        {
            CLASES.EstudiantesSQL ObjetestSQL = new CLASES.EstudiantesSQL();
            cmb_beneficio.DataSource = ObjetestSQL.Listar_Beneficio();
            cmb_beneficio.DisplayMember = "Descripcion";
            cmb_beneficio.ValueMember = "id_beneficio";

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter leerFilas = new SqlDataAdapter();

            //declaramos variables que recibe valores que el usuario ingresa
            string rut_e = txt_edad_e.Text;
            string nombre_e = txt_edad_e.Text;
            int genero_e = Convert.ToInt32(cmb_genero.SelectedValue.ToString());
            string direccion_e = txt_edad_e.Text;
            int comuna_e = Convert.ToInt32(cmb_comuna.SelectedValue.ToString());
            string fonoA = txt_edad_e.Text;
            string fonoB = txt_edad_e.Text;
            string fnac_e = dtp_Fnac_e.Text;
            string edadmarzo_e = txt_edad_e.Text;
            string nacionalidad_e = txt_edad_e.Text;
            string estproc_e = txt_edad_e.Text;
            string repit_e = txt_edad_e.Text;
            string currepit_e = txt_edad_e.Text;
            int salida_e = Convert.ToInt32(cmb_salida.SelectedValue.ToString());
            int benef_e = Convert.ToInt32(cmb_beneficio.SelectedValue.ToString());
            string nee = txt_edad_e.Text;
            int vivecon_e = Convert.ToInt32(cmb_vivecon.SelectedValue.ToString());

            //enviamos el valor de las variables a los metodos set de la clase Dadministradores
            Objdestud.set_rut_e(rut_e);
            Objdestud.set_nombre_e(nombre_e);
            Objdestud.set_genero_e(genero_e);
            Objdestud.set_direccion_e(direccion_e);
            Objdestud.set_comuna_e(comuna_e);
            Objdestud.set_fonoA(fonoA);
            Objdestud.set_fonoB(fonoB);
            Objdestud.set_fnac_e(fnac_e);
            Objdestud.set_edadmarzo_e(edadmarzo_e);
            Objdestud.set_nacionalidad_e(nacionalidad_e);
            Objdestud.set_estproc_e(estproc_e);
            Objdestud.set_repit_e(repit_e);
            Objdestud.set_currepit_e(currepit_e);
            Objdestud.set_salida_e(salida_e);
            Objdestud.set_benef_e(benef_e);
            Objdestud.set_nee(nee);
            Objdestud.set_vivecon_e(vivecon_e);

           
        }
    }
}