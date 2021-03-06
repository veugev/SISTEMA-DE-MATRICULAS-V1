﻿using System;
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
    public partial class ModificarUsu: Form
    {


        CLASES.AdminSQL Objadministradoresql = new CLASES.AdminSQL();
        CLASES.Dadministradores Objdadmin = new CLASES.Dadministradores();



        public ModificarUsu()
        {
            InitializeComponent();

            

            //agregar imagen a botones

            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;


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
            Objdadmin.set_rut(rut);
            Objdadmin.set_nombre(nom);
            Objdadmin.set_usuario(usadm);
            Objdadmin.set_password(pass);
            Objdadmin.set_tipoUsuario(tipous);

            if (txt_rutadmin.Text != String.Empty && txt_nombreadm.Text != String.Empty && txt_usuarioadm.Text != String.Empty && txt_pass.Text != String.Empty && combobox_tipo.SelectedIndex.ToString() != String.Empty)
            {
                //invocar al metodo insertar
                Objadministradoresql.Modificar_admin(Objdadmin);

                //limpiar 
                txt_rutadmin.Clear();
                txt_nombreadm.Clear();
                txt_usuarioadm.Clear();
                txt_pass.Clear();
                combobox_tipo.SelectedIndex = -1;

                ListarAdmin();

                MessageBox.Show("El Usuario fue insertado exitosamente");
                
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }

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

            ListarAdmin();

        }

        private void txt_rutadmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Administradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(dgv_Administradores.SelectedRows.Count > 0)
            {
                txt_rutadmin.Text = dgv_Administradores.CurrentRow.Cells[0].Value.ToString();
                txt_nombreadm.Text = dgv_Administradores.CurrentRow.Cells[1].Value.ToString();
                txt_usuarioadm.Text = dgv_Administradores.CurrentRow.Cells[2].Value.ToString();
                txt_pass.Text = dgv_Administradores.CurrentRow.Cells[3].Value.ToString();
                combobox_tipo.Text = dgv_Administradores.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        public void ListarAdmin()
        {
            CLASES.AdminSQL ObjetadminSQL = new CLASES.AdminSQL();
            dgv_Administradores.DataSource = ObjetadminSQL.Listar_administradores();

        }
    }
}
