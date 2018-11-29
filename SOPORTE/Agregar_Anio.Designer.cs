namespace SISTEMA_DE_MATRICULA_V1
{
    partial class Agregar_Anio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.dgv_AdmAnio = new System.Windows.Forms.DataGridView();
            this.btn_guardarAnio = new System.Windows.Forms.Button();
            this.btn_eliminar_anio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdmAnio)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(242, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIONAR AÑOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(59, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese Año";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_anio
            // 
            this.txt_anio.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_anio.Location = new System.Drawing.Point(177, 129);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(270, 30);
            this.txt_anio.TabIndex = 14;
            // 
            // dgv_AdmAnio
            // 
            this.dgv_AdmAnio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_AdmAnio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_AdmAnio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_AdmAnio.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_AdmAnio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AdmAnio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_AdmAnio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_AdmAnio.Location = new System.Drawing.Point(177, 239);
            this.dgv_AdmAnio.Name = "dgv_AdmAnio";
            this.dgv_AdmAnio.RowHeadersVisible = false;
            this.dgv_AdmAnio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AdmAnio.Size = new System.Drawing.Size(270, 150);
            this.dgv_AdmAnio.TabIndex = 21;
            this.dgv_AdmAnio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AdmAnio_CellContentClick);
            // 
            // btn_guardarAnio
            // 
            this.btn_guardarAnio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_guardarAnio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardarAnio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardarAnio.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_guardarAnio.FlatAppearance.BorderSize = 0;
            this.btn_guardarAnio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_guardarAnio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_guardarAnio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarAnio.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarAnio.ForeColor = System.Drawing.Color.White;
            this.btn_guardarAnio.Location = new System.Drawing.Point(496, 119);
            this.btn_guardarAnio.Name = "btn_guardarAnio";
            this.btn_guardarAnio.Size = new System.Drawing.Size(142, 52);
            this.btn_guardarAnio.TabIndex = 22;
            this.btn_guardarAnio.Text = "GUARDAR";
            this.btn_guardarAnio.UseVisualStyleBackColor = false;
            this.btn_guardarAnio.Click += new System.EventHandler(this.btn_guardarAnio_Click);
            // 
            // btn_eliminar_anio
            // 
            this.btn_eliminar_anio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_eliminar_anio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_anio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_anio.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar_anio.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_anio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar_anio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar_anio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_anio.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_anio.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_anio.Location = new System.Drawing.Point(496, 202);
            this.btn_eliminar_anio.Name = "btn_eliminar_anio";
            this.btn_eliminar_anio.Size = new System.Drawing.Size(142, 52);
            this.btn_eliminar_anio.TabIndex = 23;
            this.btn_eliminar_anio.Text = "ELIMINAR";
            this.btn_eliminar_anio.UseVisualStyleBackColor = false;
            this.btn_eliminar_anio.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agregar_Anio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_eliminar_anio);
            this.Controls.Add(this.btn_guardarAnio);
            this.Controls.Add(this.dgv_AdmAnio);
            this.Controls.Add(this.txt_anio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Agregar_Anio";
            this.Text = "Agregar_Anio";
            this.Load += new System.EventHandler(this.Agregar_Anio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdmAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.DataGridView dgv_AdmAnio;
        private System.Windows.Forms.Button btn_guardarAnio;
        private System.Windows.Forms.Button btn_eliminar_anio;
    }
}