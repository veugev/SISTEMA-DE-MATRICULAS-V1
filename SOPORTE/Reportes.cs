﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1
{
    public partial class Reportes: Form
    {
        public Reportes()
        {
            InitializeComponent();
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
            button3.BackgroundImage = Properties.Resources.button_icon_png_20;
            button4.BackgroundImage = Properties.Resources.button_icon_png_20;
            button5.BackgroundImage = Properties.Resources.button_icon_png_20;
            button6.BackgroundImage = Properties.Resources.button_icon_png_20;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoginAdm cambiarform = new LoginAdm();
            cambiarform.Show();
            this.Hide();
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginDir cambiarform3 = new LoginDir ();
            cambiarform3.Show();
            this.Hide();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.button_icon_png_21;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.button_icon_png_20;
        }

        private void Tipos_Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }
    }
}


