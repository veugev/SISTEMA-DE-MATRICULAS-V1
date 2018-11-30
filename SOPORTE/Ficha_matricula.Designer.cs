namespace SISTEMA_DE_MATRICULA_V1.SOPORTE
{
    partial class Ficha_matricula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosFamiliaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeLaMadreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelPadreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelApoderadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_contenedor2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarAlumnoToolStripMenuItem,
            this.datosFamiliaresToolStripMenuItem,
            this.datosDeMatriculaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresarAlumnoToolStripMenuItem
            // 
            this.ingresarAlumnoToolStripMenuItem.Name = "ingresarAlumnoToolStripMenuItem";
            this.ingresarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.ingresarAlumnoToolStripMenuItem.Text = "Ingresar Alumno";
            this.ingresarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.ingresarAlumnoToolStripMenuItem_Click);
            // 
            // datosDeMatriculaToolStripMenuItem
            // 
            this.datosDeMatriculaToolStripMenuItem.Name = "datosDeMatriculaToolStripMenuItem";
            this.datosDeMatriculaToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.datosDeMatriculaToolStripMenuItem.Text = "Datos de matricula";
            this.datosDeMatriculaToolStripMenuItem.Click += new System.EventHandler(this.datosDeMatriculaToolStripMenuItem_Click);
            // 
            // datosFamiliaresToolStripMenuItem
            // 
            this.datosFamiliaresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeLaMadreToolStripMenuItem,
            this.datosDelPadreToolStripMenuItem,
            this.datosDelApoderadoToolStripMenuItem});
            this.datosFamiliaresToolStripMenuItem.Name = "datosFamiliaresToolStripMenuItem";
            this.datosFamiliaresToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.datosFamiliaresToolStripMenuItem.Text = "Datos Familiares";
            // 
            // datosDeLaMadreToolStripMenuItem
            // 
            this.datosDeLaMadreToolStripMenuItem.Name = "datosDeLaMadreToolStripMenuItem";
            this.datosDeLaMadreToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.datosDeLaMadreToolStripMenuItem.Text = "Datos de la Madre";
            this.datosDeLaMadreToolStripMenuItem.Click += new System.EventHandler(this.datosDeLaMadreToolStripMenuItem_Click);
            // 
            // datosDelPadreToolStripMenuItem
            // 
            this.datosDelPadreToolStripMenuItem.Name = "datosDelPadreToolStripMenuItem";
            this.datosDelPadreToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.datosDelPadreToolStripMenuItem.Text = "Datos del Padre";
            this.datosDelPadreToolStripMenuItem.Click += new System.EventHandler(this.datosDelPadreToolStripMenuItem_Click);
            // 
            // datosDelApoderadoToolStripMenuItem
            // 
            this.datosDelApoderadoToolStripMenuItem.Name = "datosDelApoderadoToolStripMenuItem";
            this.datosDelApoderadoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.datosDelApoderadoToolStripMenuItem.Text = "Datos del Apoderado";
            this.datosDelApoderadoToolStripMenuItem.Click += new System.EventHandler(this.datosDelApoderadoToolStripMenuItem_Click);
            // 
            // panel_contenedor2
            // 
            this.panel_contenedor2.AutoScroll = true;
            this.panel_contenedor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor2.Location = new System.Drawing.Point(0, 24);
            this.panel_contenedor2.Name = "panel_contenedor2";
            this.panel_contenedor2.Size = new System.Drawing.Size(800, 426);
            this.panel_contenedor2.TabIndex = 3;
            this.panel_contenedor2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor2_Paint);
            // 
            // Ficha_matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel_contenedor2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ficha_matricula";
            this.Text = "Ficha_matricula";
            this.Load += new System.EventHandler(this.Ficha_matricula_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosFamiliaresToolStripMenuItem;
        private System.Windows.Forms.Panel panel_contenedor2;
        private System.Windows.Forms.ToolStripMenuItem datosDeLaMadreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelPadreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelApoderadoToolStripMenuItem;
    }
}