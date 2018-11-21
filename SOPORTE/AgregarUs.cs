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
    public partial class AgregarUs : Form
    {

        CLASES.Datos datito=new CLASES.Datos();
        CLASES.Dadministradores dadm = new CLASES.Dadministradores();
        BdConexion ccn = new BdConexion();

        

        public AgregarUs()
        {
            InitializeComponent();

            

            //agregar imagen a botones

            button2.BackgroundImage = Properties.Resources.button_icon_png_20;

           
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
                    string rut = txt_rutadmin.Text;
                    string nom = txt_nombreadm.Text;
                    string usadm = txt_usuarioadm.Text;
                    string pass = txt_pass.Text;
                    string tipous = combobox_tipo.SelectedItem.ToString();

                    //enviamos el valor de las variables a los metodos set de la clase Dadministradores
                    dadm.set_rut(rut);
                    dadm.set_nombre(nom);
                    dadm.set_usuario(usadm);
                    dadm.set_password(pass);
                    dadm.set_tipoUsuario(tipous);

            if (txt_rutadmin.Text != String.Empty && txt_nombreadm.Text != String.Empty && txt_usuarioadm.Text != String.Empty && txt_pass.Text != String.Empty && combobox_tipo.SelectedIndex.ToString() != String.Empty) {
                if (datito.Persona_registrada(dadm)==0)
                {
                    

                    //invocar al metodo insertar
                    datito.Insertar_usuario(dadm);

                    // refrescamos datagridview
                    datito.Cargar_Administrativos(dgv_Administradores);

                    //limpiar 
                    txt_rutadmin.Clear();
                    txt_nombreadm.Clear();
                    txt_usuarioadm.Clear();
                    txt_pass.Clear();
                    combobox_tipo.SelectedIndex = -1;

                    MessageBox.Show("El Usuario fue insertado exitosamente");
                }
                else
                {
                    MessageBox.Show("El Usuario ya existe");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }



            //dd

        }

        

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button2.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            //volver al color de imagen de inicio de boton al salir de encima
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarUs_Load(object sender, EventArgs e)
        {
            

            datito.Cargar_Administrativos(dgv_Administradores);
        }

        
    }
}
