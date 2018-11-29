namespace SISTEMA_DE_MATRICULA_V1.SOPORTE
{
    partial class Mantencion_tablas
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
            this.AnioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_años = new System.Windows.Forms.Panel();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnioToolStripMenuItem,
            this.ComunasToolStripMenuItem,
            this.ProfesoresToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AnioToolStripMenuItem
            // 
            this.AnioToolStripMenuItem.Name = "AnioToolStripMenuItem";
            this.AnioToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.AnioToolStripMenuItem.Text = "Mantenedor Años";
            this.AnioToolStripMenuItem.Click += new System.EventHandler(this.ingresarAlumnoToolStripMenuItem_Click);
            // 
            // ComunasToolStripMenuItem
            // 
            this.ComunasToolStripMenuItem.Name = "ComunasToolStripMenuItem";
            this.ComunasToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.ComunasToolStripMenuItem.Text = "Mantenedor Comunas";
            this.ComunasToolStripMenuItem.Click += new System.EventHandler(this.datosDeMatriculaToolStripMenuItem_Click);
            // 
            // ProfesoresToolStripMenuItem
            // 
            this.ProfesoresToolStripMenuItem.Name = "ProfesoresToolStripMenuItem";
            this.ProfesoresToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.ProfesoresToolStripMenuItem.Text = "Mantenedor Profesores";
            // 
            // panel_años
            // 
            this.panel_años.AutoScroll = true;
            this.panel_años.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_años.Location = new System.Drawing.Point(0, 24);
            this.panel_años.Name = "panel_años";
            this.panel_años.Size = new System.Drawing.Size(800, 426);
            this.panel_años.TabIndex = 3;
            this.panel_años.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor2_Paint);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // Mantencion_tablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel_años);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mantencion_tablas";
            this.Text = "Ficha_matricula";
            this.Load += new System.EventHandler(this.Ficha_matricula_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AnioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfesoresToolStripMenuItem;
        private System.Windows.Forms.Panel panel_años;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
    }
}