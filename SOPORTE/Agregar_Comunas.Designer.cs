namespace SISTEMA_DE_MATRICULA_V1.SOPORTE
{
    partial class Agregar_Comunas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_comuna = new System.Windows.Forms.TextBox();
            this.dgv_Admcomuna = new System.Windows.Forms.DataGridView();
            this.btn_guardarComuna = new System.Windows.Forms.Button();
            this.btn_eliminar_Comuna = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admcomuna)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(189, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIONAR COMUNAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese Comuna";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_comuna
            // 
            this.txt_comuna.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comuna.Location = new System.Drawing.Point(177, 129);
            this.txt_comuna.Name = "txt_comuna";
            this.txt_comuna.Size = new System.Drawing.Size(270, 30);
            this.txt_comuna.TabIndex = 14;
            // 
            // dgv_Admcomuna
            // 
            this.dgv_Admcomuna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Admcomuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Admcomuna.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Admcomuna.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Admcomuna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Admcomuna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Admcomuna.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Admcomuna.Location = new System.Drawing.Point(63, 240);
            this.dgv_Admcomuna.Name = "dgv_Admcomuna";
            this.dgv_Admcomuna.RowHeadersVisible = false;
            this.dgv_Admcomuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Admcomuna.Size = new System.Drawing.Size(354, 150);
            this.dgv_Admcomuna.TabIndex = 21;
            this.dgv_Admcomuna.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AdmAnio_CellContentClick);
            // 
            // btn_guardarComuna
            // 
            this.btn_guardarComuna.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_guardarComuna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardarComuna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardarComuna.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_guardarComuna.FlatAppearance.BorderSize = 0;
            this.btn_guardarComuna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_guardarComuna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_guardarComuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarComuna.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarComuna.ForeColor = System.Drawing.Color.White;
            this.btn_guardarComuna.Location = new System.Drawing.Point(496, 119);
            this.btn_guardarComuna.Name = "btn_guardarComuna";
            this.btn_guardarComuna.Size = new System.Drawing.Size(142, 52);
            this.btn_guardarComuna.TabIndex = 22;
            this.btn_guardarComuna.Text = "GUARDAR";
            this.btn_guardarComuna.UseVisualStyleBackColor = false;
            this.btn_guardarComuna.Click += new System.EventHandler(this.btn_guardarAnio_Click);
            // 
            // btn_eliminar_Comuna
            // 
            this.btn_eliminar_Comuna.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_eliminar_Comuna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_Comuna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_Comuna.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar_Comuna.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_Comuna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar_Comuna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar_Comuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_Comuna.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_Comuna.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_Comuna.Location = new System.Drawing.Point(496, 202);
            this.btn_eliminar_Comuna.Name = "btn_eliminar_Comuna";
            this.btn_eliminar_Comuna.Size = new System.Drawing.Size(142, 52);
            this.btn_eliminar_Comuna.TabIndex = 23;
            this.btn_eliminar_Comuna.Text = "ELIMINAR";
            this.btn_eliminar_Comuna.UseVisualStyleBackColor = false;
            this.btn_eliminar_Comuna.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agregar_Comunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_eliminar_Comuna);
            this.Controls.Add(this.btn_guardarComuna);
            this.Controls.Add(this.dgv_Admcomuna);
            this.Controls.Add(this.txt_comuna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Agregar_Comunas";
            this.Text = "Agregar_Anio";
            this.Load += new System.EventHandler(this.Agregar_Comunas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admcomuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_comuna;
        private System.Windows.Forms.DataGridView dgv_Admcomuna;
        private System.Windows.Forms.Button btn_guardarComuna;
        private System.Windows.Forms.Button btn_eliminar_Comuna;
    }
}