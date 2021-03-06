﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class Tipos_Usuario : Form
    {
        public Tipos_Usuario()
        {
            InitializeComponent();

            //agregar imagen a botones

            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;


            //bloquear el maximizar y agrandar tamaño

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //ir a formulario login Administradores
            LoginAdm cambiarform = new LoginAdm();
            cambiarform.Show();

            //ocultar formulario al abrir otro
            this.Hide();
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ir a formulario login Administradores
            LoginDir cambiarform3 = new LoginDir ();
            cambiarform3.Show();

            //ocultar formulario al abrir otro
            this.Hide();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button1.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //volver al color e imagen de inicio de boton al salir de encima
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiar color e imagen de boton al pasar por arriba
            button2.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            //volver al color e imagen de inicio de boton al salir de encima
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        private void Tipos_Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            //cerrar aplicacion
            Application.Exit();
        }

        private void Tipos_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}


