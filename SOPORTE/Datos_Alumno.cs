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



namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class Datos_Alumno : Form
    {

        CLASES.EstudiantesSQL Objestudiantesql = new CLASES.EstudiantesSQL();
        CLASES.Destudiantes Objdestud = new CLASES.Destudiantes();
        public Datos_Alumno()
        {
            InitializeComponent();
            
            button1.BackgroundImage = Properties.Resources.Btn_Verde;
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
            button4.BackgroundImage = Properties.Resources.button_icon_png_20;



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
                string rut_e = txt_rut_e.Text;
                string nombre_e = txt_nombre_e.Text;
                int genero_e = Convert.ToInt32(cmb_genero.SelectedValue.ToString());
                string direccion_e = txt_direccion_e.Text;
                int comuna_e = Convert.ToInt32(cmb_comuna.SelectedValue.ToString());
                string fonoA = txt_fonoa.Text;
                string fonoB = txt_fonob.Text;
                string fnac_e = dtp_Fnac_e.Text;
                string edadmarzo_e = txt_edad_e.Text;
                string nacionalidad_e = cmb_nacionalidad.SelectedItem.ToString();
                string estproc_e = txt_proc_e.Text;
                string repit_e = cmb_repitencia.SelectedItem.ToString();
                string currepit_e = txt_currepit_e.Text;
                int salida_e = Convert.ToInt32(cmb_salida.SelectedValue.ToString());
                int benef_e = Convert.ToInt32(cmb_beneficio.SelectedValue.ToString());
                string nee = cmb_Nee.SelectedItem.ToString();
                int vivecon_e = Convert.ToInt32(cmb_vivecon.SelectedValue.ToString());
                string padre = cmb_padre.SelectedValue.ToString();
                string madre = cmb_madre.SelectedValue.ToString();


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
                Objdestud.set_padre(padre);
                Objdestud.set_madre(madre);
                


                if (txt_rut_e.Text != String.Empty &&
                    txt_nombre_e.Text != String.Empty && dtp_Fnac_e.Text != String.Empty && txt_edad_e.Text != String.Empty &&
                    txt_direccion_e.Text != String.Empty && txt_fonoa.Text != String.Empty && txt_fonob.Text != String.Empty &&
                    txt_proc_e.Text != String.Empty && txt_currepit_e.Text != String.Empty)
                {

                    //invocar al metodo insertar
                    Objestudiantesql.InsertarEstud(Objdestud);

                    //limpiar 
                    txt_rut_e.Clear();
                    cmb_genero.SelectedIndex = -1;
                    txt_nombre_e.Clear();
                    txt_edad_e.Clear();
                    cmb_nacionalidad.SelectedIndex = -1;
                    cmb_comuna.SelectedIndex = -1;
                    txt_direccion_e.Clear();
                    cmb_salida.SelectedIndex = -1;
                    cmb_vivecon.SelectedIndex = -1;
                    txt_fonoa.Clear();
                    txt_fonob.Clear();
                    txt_proc_e.Clear();
                    cmb_repitencia.SelectedIndex = -1;
                    txt_currepit_e.Clear();
                    cmb_Nee.SelectedIndex = -1;
                    cmb_beneficio.SelectedIndex = -1;
                    cmb_madre.SelectedIndex = -1;
                    cmb_padre.SelectedIndex = -1;

                    MessageBox.Show("Datos ingresados exitosamente");

                    ListarEstud();
                }
                else
                {
                    MessageBox.Show("Debe ingresar todos los datos");
                }

            
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
            ListarEstud();
            ListarMama();
            ListarPapa();


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
        public void ListarMama()
        {
            CLASES.EstudiantesSQL ObjetestSQL = new CLASES.EstudiantesSQL();
            cmb_madre.DataSource = ObjetestSQL.Listar_Mama();
            cmb_madre.DisplayMember = "Nombre_Madre";
            cmb_madre.ValueMember = "id_RutM";

        }

        public void ListarPapa()
        {
            CLASES.EstudiantesSQL ObjetestSQL = new CLASES.EstudiantesSQL();
            cmb_padre.DataSource = ObjetestSQL.Listar_Papa();
            cmb_padre.DisplayMember = "Nombre_Padre";
            cmb_padre.ValueMember = "id_RutP";

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgv_Estudiantes.SelectedRows.Count > 0)
            {
                txt_rut_e.Text = dgv_Estudiantes.CurrentRow.Cells[0].Value.ToString();
                txt_nombre_e.Text = dgv_Estudiantes.CurrentRow.Cells[1].Value.ToString();
                cmb_genero.Text = dgv_Estudiantes.CurrentRow.Cells[2].Value.ToString();
                txt_direccion_e.Text = dgv_Estudiantes.CurrentRow.Cells[3].Value.ToString();
                cmb_comuna.Text = dgv_Estudiantes.CurrentRow.Cells[4].Value.ToString();
                txt_fonoa.Text = dgv_Estudiantes.CurrentRow.Cells[5].Value.ToString();
                txt_fonob.Text = dgv_Estudiantes.CurrentRow.Cells[6].Value.ToString();
                dtp_Fnac_e.Text = dgv_Estudiantes.CurrentRow.Cells[7].Value.ToString();
                txt_edad_e.Text = dgv_Estudiantes.CurrentRow.Cells[8].Value.ToString();
                cmb_nacionalidad.Text = dgv_Estudiantes.CurrentRow.Cells[9].Value.ToString();
                txt_proc_e.Text = dgv_Estudiantes.CurrentRow.Cells[10].Value.ToString();
                cmb_repitencia.Text = dgv_Estudiantes.CurrentRow.Cells[11].Value.ToString();
                txt_currepit_e.Text = dgv_Estudiantes.CurrentRow.Cells[12].Value.ToString();
                cmb_salida.Text = dgv_Estudiantes.CurrentRow.Cells[13].Value.ToString();
                cmb_beneficio.Text = dgv_Estudiantes.CurrentRow.Cells[14].Value.ToString();
                cmb_Nee.Text = dgv_Estudiantes.CurrentRow.Cells[15].Value.ToString();
                cmb_vivecon.Text = dgv_Estudiantes.CurrentRow.Cells[16].Value.ToString();
            }


        }

        public void ListarEstud()
        {
            CLASES.EstudiantesSQL ObjetestudiantesSQL = new CLASES.EstudiantesSQL();
            dgv_Estudiantes.DataSource = ObjetestudiantesSQL.Listar_Estudiantes();

        }

        private void dgv_Estudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //declaramos variables que recibe valores que el usuario ingresa
            string rut_e = txt_rut_e.Text;
            string nombre_e = txt_nombre_e.Text;
            int genero_e = Convert.ToInt32(cmb_genero.SelectedValue.ToString());
            string direccion_e = txt_direccion_e.Text;
            int comuna_e = Convert.ToInt32(cmb_comuna.SelectedValue.ToString());
            string fonoA = txt_fonoa.Text;
            string fonoB = txt_fonob.Text;
            string fnac_e = dtp_Fnac_e.Text;
            string edadmarzo_e = txt_edad_e.Text;
            string nacionalidad_e = cmb_nacionalidad.SelectedItem.ToString();
            string estproc_e = txt_proc_e.Text;
            string repit_e = cmb_repitencia.Text;
            string currepit_e = txt_currepit_e.Text;
            int salida_e = Convert.ToInt32(cmb_salida.SelectedValue.ToString());
            int benef_e = Convert.ToInt32(cmb_beneficio.SelectedValue.ToString());
            string nee = cmb_Nee.Text;
            int vivecon_e = Convert.ToInt32(cmb_vivecon.SelectedValue.ToString());
            string madre = cmb_madre.SelectedValue.ToString();
            string padre = cmb_padre.SelectedValue.ToString();

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
            Objdestud.set_madre(madre);
            Objdestud.set_padre(padre);



            //invocar al metodo insertar
            Objestudiantesql.ModificarEstud(Objdestud);

                //limpiar 
                txt_rut_e.Clear();
                cmb_genero.SelectedIndex = -1;
                txt_nombre_e.Clear();
                txt_edad_e.Clear();
                cmb_nacionalidad.SelectedIndex = -1;
                cmb_comuna.SelectedIndex = -1;
                txt_direccion_e.Clear();
                cmb_salida.SelectedIndex = -1;
                cmb_vivecon.SelectedIndex = -1;
                txt_fonoa.Clear();
                txt_fonob.Clear();
                txt_proc_e.Clear();
                cmb_repitencia.SelectedIndex = -1;
                txt_currepit_e.Clear();
                cmb_Nee.SelectedIndex = -1;
                cmb_beneficio.SelectedIndex = -1;
                cmb_madre.SelectedIndex = -1;
                cmb_padre.SelectedIndex = -1;

            MessageBox.Show("Datos modificados exitosamente");
                ListarEstud();

            
            
        }
    }
}