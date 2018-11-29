namespace SISTEMA_DE_MATRICULA_V1
{
    partial class Mantencion_Datos
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
            this.MantenedoranioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MantenedorComunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MantenedorprofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_contenedor3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenedoranioToolStripMenuItem,
            this.MantenedorComunasToolStripMenuItem,
            this.MantenedorprofToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MantenedoranioToolStripMenuItem
            // 
            this.MantenedoranioToolStripMenuItem.Name = "MantenedoranioToolStripMenuItem";
            this.MantenedoranioToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.MantenedoranioToolStripMenuItem.Text = "Mantenedor Años";
            this.MantenedoranioToolStripMenuItem.Click += new System.EventHandler(this.ingresarAlumnoToolStripMenuItem_Click);
            // 
            // MantenedorComunasToolStripMenuItem
            // 
            this.MantenedorComunasToolStripMenuItem.Name = "MantenedorComunasToolStripMenuItem";
            this.MantenedorComunasToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.MantenedorComunasToolStripMenuItem.Text = "Mantenedor Comunas";
            this.MantenedorComunasToolStripMenuItem.Click += new System.EventHandler(this.datosDeMatriculaToolStripMenuItem_Click);
            // 
            // MantenedorprofToolStripMenuItem
            // 
            this.MantenedorprofToolStripMenuItem.Name = "MantenedorprofToolStripMenuItem";
            this.MantenedorprofToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.MantenedorprofToolStripMenuItem.Text = "Mantenedor Profesores";
            this.MantenedorprofToolStripMenuItem.Click += new System.EventHandler(this.datosFamiliaresToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // panel_contenedor3
            // 
            this.panel_contenedor3.AutoScroll = true;
            this.panel_contenedor3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor3.Location = new System.Drawing.Point(0, 24);
            this.panel_contenedor3.Name = "panel_contenedor3";
            this.panel_contenedor3.Size = new System.Drawing.Size(800, 426);
            this.panel_contenedor3.TabIndex = 3;
            this.panel_contenedor3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor2_Paint);
            // 
            // Mantencion_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel_contenedor3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mantencion_Datos";
            this.Text = "Ficha_matricula";
            this.Load += new System.EventHandler(this.Ficha_matricula_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MantenedoranioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MantenedorComunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MantenedorprofToolStripMenuItem;
        private System.Windows.Forms.Panel panel_contenedor3;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
    }
}