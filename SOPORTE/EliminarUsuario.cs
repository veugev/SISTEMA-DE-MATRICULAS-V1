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
    public partial class EliminarUsuario : Form
    {

        CLASES.Dadministradores dadm = new CLASES.Dadministradores();
        BdConexion ccn = new BdConexion();

        

        public EliminarUsuario()
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
            

        }

        
    }
}