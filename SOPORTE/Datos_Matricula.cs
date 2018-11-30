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
    public partial class Datos_Matricula : Form
    {

        FichaMatriSQL Objmatriculasql = new FichaMatriSQL();
        DfichaMatri Objdmatr = new DfichaMatri();

        public Datos_Matricula()
        {
            InitializeComponent();

            button4.BackgroundImage = Properties.Resources.Btn_Verde;
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        private void AgregarDir_Load(object sender, EventArgs e)
        {
            ListarAnio();
            ListarCurso();
            ListarEstadoalum();
            Listargrado();
            ListarPersonas();
            ListarProfesor();
            Listartipoalum();
            ListarTipoEnsenanza();
            ListarMatri();
                 
    

        }

        public void ListarAnio()
        {
            FichaMatriSQL ObjmatriculaSQL = new FichaMatriSQL();
            cmb_anio.DataSource = ObjmatriculaSQL.Listar_anio();
            cmb_anio.DisplayMember = "Descripcion";
            cmb_anio.ValueMember = "id_anio";
        }

        public void Listartipoalum()
        {
            FichaMatriSQL ObjmatriculaSQL = new FichaMatriSQL();
            cmb_tipoal.DataSource = ObjmatriculaSQL.Listar_tipoalumno();
            cmb_tipoal.DisplayMember = "Descripcion";
            cmb_tipoal.ValueMember = "id_tipoalumno";
        }

        public void ListarEstadoalum()
        {
            FichaMatriSQL ObjmatriculaSQL = new FichaMatriSQL();
            cmb_estado.DataSource = ObjmatriculaSQL.Listar_estadoalum();
            cmb_estado.DisplayMember = "Descripcion";
            cmb_estado.ValueMember = "id_estadoalum";
        }

        public void ListarProfesor()
        {
            FichaMatriSQL ObjmatriculaSQL = new FichaMatriSQL();
            cmb_prof.DataSource = ObjmatriculaSQL.Listar_profesores();
            cmb_prof.DisplayMember = "Descricion";
            cmb_prof.ValueMember = "id_profesor";
        }

        public void ListarTipoEnsenanza()
        {
            FichaMatriSQL ObjmatriculaSQL = new FichaMatriSQL();
            cmb_ensenanza.DataSource = ObjmatriculaSQL.Listar_tipoensenanza();
            cmb_ensenanza.DisplayMember = "Descripcion";
            cmb_ensenanza.ValueMember = "id_tipo_ensenanza";
        }

        public void Listargrado()
        {
            FichaMatriSQL ObjmatriculaSQL = new FichaMatriSQL();
            cmb_grado.DataSource = ObjmatriculaSQL.Listar_grado();
            cmb_grado.DisplayMember = "Descripcion";
            cmb_grado.ValueMember = "id_grado";
        }

        public void ListarCurso()
        {
            FichaMatriSQL ObjmatriculaSQL = new FichaMatriSQL();
            cmb_curso.DataSource = ObjmatriculaSQL.Listar_curso();
            cmb_curso.DisplayMember = "Descripcion";
            cmb_curso.ValueMember = "id_curso";
        }

        public void ListarPersonas()
        {
            FichaMatriSQL ObjmatriculaSQL = new FichaMatriSQL();
            cmb_curso.DataSource = ObjmatriculaSQL.Listar_Personas();
            cmb_curso.DisplayMember = "NOMBRE_PERSONA";
            cmb_curso.ValueMember = "RUT";
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            int anio = Convert.ToInt32(cmb_anio.SelectedValue.ToString());
            int tipoalumno = Convert.ToInt32(cmb_tipoal.SelectedValue.ToString());
            int estadoalumno = Convert.ToInt32(cmb_estado.SelectedValue.ToString());
            int profesor = Convert.ToInt32(cmb_prof.SelectedValue.ToString());
            int tipoensenanza = Convert.ToInt32(cmb_ensenanza.SelectedValue.ToString());
            int grado = Convert.ToInt32(cmb_grado.SelectedValue.ToString());
            int curso = Convert.ToInt32(cmb_curso.SelectedValue.ToString());
            string fecha_ingreso = dtp_Fingreso.Text;
            string fecha_retiro = dtp_Fretiro.Text;
            string fecha_egreso = dtp_fegreso.Text;
            int rut_p = Convert.ToInt32(cmb_apoderado.SelectedValue.ToString());

            //enviamos el valor de las variables a los metodos set de la clase Dadministradores

            Objdmatr.set_anio(anio);
            Objdmatr.set_curso(curso);
            Objdmatr.set_estadoalum(estadoalumno);
            Objdmatr.set_fechaegreso(fecha_egreso);
            Objdmatr.set_fechaingreso(fecha_ingreso);
            Objdmatr.set_fecharetiro(fecha_retiro);
            Objdmatr.set_grado(grado);
            
            Objdmatr.set_profesor(profesor);
            Objdmatr.set_rut_p(rut_p);
            Objdmatr.set_tipoalumno(tipoalumno);
            Objdmatr.set_tipoensenanza(tipoensenanza);

            if (dtp_fegreso.Text != String.Empty &&
                dtp_Fingreso.Text != String.Empty &&
                dtp_Fretiro.Text != String.Empty 
                )
            {
                //invocar al metodo insertar
                Objmatriculasql.InsertarMatri(Objdmatr);

                //limpiar 
                txt_ocupacion.Clear();
                cmb_anio.SelectedIndex = -1;
                cmb_apoderado.SelectedIndex = -1;
                cmb_curso.SelectedIndex = -1;
                cmb_ensenanza.SelectedIndex = -1;
                cmb_estado.SelectedIndex = -1;
                cmb_grado.SelectedIndex = -1;
                cmb_prof.SelectedIndex = -1;
                cmb_tipoal.SelectedIndex = -1;
                

                MessageBox.Show("Datos ingresados exitosamente");

                ListarMatri();
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        public void ListarMatri()
        {
            FichaMatriSQL ObjmatSQL = new FichaMatriSQL();
            dgv_Matricula.DataSource = ObjmatSQL.Listar_Matriculas();

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
