﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class LoginAdm : Form
    {
        public LoginAdm()
        {
            InitializeComponent();

            //agregar imagen a botones

            btn_ingresarAdm.BackgroundImage = Properties.Resources.button_icon_png_20;
            btn_volverAdm.BackgroundImage = Properties.Resources.Btn_Rojo;

            //bloquear el maximizar y agrandar tamaño
            
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            btn_ingresarAdm.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //volver al color de imagen de inicio de boton al salir de encima
            btn_ingresarAdm.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            CLASES.Dadministradores dadm = new CLASES.Dadministradores();
            CLASES.ValidarAdm valUs = new CLASES.ValidarAdm();

            if (txtusuario.Text != String.Empty && txtcontraseña.Text != String.Empty)
            {
                DataTable dt = new DataTable();

                dadm.set_usuario(txtusuario.Text);
                dadm.set_password(txtcontraseña.Text);
                dt = valUs.validar_administradores(dadm);

                if (dt.Rows.Count != 0)
                {
                    String nivel;
                    nivel = Convert.ToString(dt.Rows[0]["tipo_usuario"]);
                    if (nivel.Equals("Soporte"))
                    {
                        MessageBox.Show("Bienvenido " + txtusuario.Text);

                        //ocultar formulario al abrir otro
                        this.Hide();

                        Perfil_Soporte volverform = new Perfil_Soporte();
                        volverform.Show();
                    }
                    else if (nivel.Equals("Administrador"))
                    {
                        MessageBox.Show("Bienvenido " + txtusuario.Text);

                        //ocultar formulario al abrir otro
                        this.Hide();

                        Perfil_Administrador volverform = new Perfil_Administrador();
                        volverform.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Error de ingreso");
                }
            }
            else
            {
                MessageBox.Show("Ingrese sus datos");
            }
    
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
           Tipos_Usuario volverform = new Tipos_Usuario();
            volverform.Show();
            this.Close();

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            btn_volverAdm.BackgroundImage = Properties.Resources.Btn_Naranjo;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btn_volverAdm.BackgroundImage = Properties.Resources.Btn_Rojo;
        }
    }
}
