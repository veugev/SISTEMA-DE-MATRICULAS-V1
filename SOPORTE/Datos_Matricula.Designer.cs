namespace SISTEMA_DE_MATRICULA_V1
{
    partial class Datos_Matricula
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_anio = new System.Windows.Forms.ComboBox();
            this.cmb_prof = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_tipoal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.cmb_ensenanza = new System.Windows.Forms.ComboBox();
            this.cmb_grado = new System.Windows.Forms.ComboBox();
            this.cmb_curso = new System.Windows.Forms.ComboBox();
            this.dtp_Fingreso = new System.Windows.Forms.DateTimePicker();
            this.dtp_fegreso = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fretiro = new System.Windows.Forms.DateTimePicker();
            this.dgv_Estudiantes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cmb_apoderado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(221, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DE MATRICULA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(15, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo de Enseñanza";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(239, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Profesor jefe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(510, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Año";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(565, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 52);
            this.button2.TabIndex = 19;
            this.button2.Text = "GUARDAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmb_anio
            // 
            this.cmb_anio.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_anio.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_anio.FormattingEnabled = true;
            this.cmb_anio.Location = new System.Drawing.Point(587, 87);
            this.cmb_anio.Name = "cmb_anio";
            this.cmb_anio.Size = new System.Drawing.Size(111, 31);
            this.cmb_anio.TabIndex = 21;
            this.cmb_anio.Text = "Seleccione Genero...";
            this.cmb_anio.SelectedIndexChanged += new System.EventHandler(this.combobox_tipo_SelectedIndexChanged);
            // 
            // cmb_prof
            // 
            this.cmb_prof.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_prof.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_prof.FormattingEnabled = true;
            this.cmb_prof.Location = new System.Drawing.Point(360, 269);
            this.cmb_prof.Name = "cmb_prof";
            this.cmb_prof.Size = new System.Drawing.Size(337, 31);
            this.cmb_prof.TabIndex = 22;
            this.cmb_prof.Text = "Seleccione Comuna...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(15, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Curso";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(440, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Grado";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmb_tipoal
            // 
            this.cmb_tipoal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoal.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_tipoal.FormattingEnabled = true;
            this.cmb_tipoal.Location = new System.Drawing.Point(163, 149);
            this.cmb_tipoal.Name = "cmb_tipoal";
            this.cmb_tipoal.Size = new System.Drawing.Size(191, 31);
            this.cmb_tipoal.TabIndex = 28;
            this.cmb_tipoal.Text = "Seleccione...";
            this.cmb_tipoal.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(15, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tipo de Alumno";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(435, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 23);
            this.label11.TabIndex = 31;
            this.label11.Text = "Estado";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(15, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 23);
            this.label12.TabIndex = 34;
            this.label12.Text = "Fecha Retiro";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(359, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 23);
            this.label14.TabIndex = 37;
            this.label14.Text = "Fecha Egreso";
            // 
            // cmb_estado
            // 
            this.cmb_estado.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_estado.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(507, 149);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(191, 31);
            this.cmb_estado.TabIndex = 45;
            this.cmb_estado.Text = "Seleccione...";
            // 
            // cmb_ensenanza
            // 
            this.cmb_ensenanza.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ensenanza.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_ensenanza.FormattingEnabled = true;
            this.cmb_ensenanza.Location = new System.Drawing.Point(190, 209);
            this.cmb_ensenanza.Name = "cmb_ensenanza";
            this.cmb_ensenanza.Size = new System.Drawing.Size(191, 31);
            this.cmb_ensenanza.TabIndex = 46;
            this.cmb_ensenanza.Text = "Seleccione...";
            // 
            // cmb_grado
            // 
            this.cmb_grado.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_grado.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_grado.FormattingEnabled = true;
            this.cmb_grado.Location = new System.Drawing.Point(507, 209);
            this.cmb_grado.Name = "cmb_grado";
            this.cmb_grado.Size = new System.Drawing.Size(191, 31);
            this.cmb_grado.TabIndex = 47;
            this.cmb_grado.Text = "Seleccione...";
            // 
            // cmb_curso
            // 
            this.cmb_curso.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_curso.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_curso.FormattingEnabled = true;
            this.cmb_curso.Location = new System.Drawing.Point(78, 269);
            this.cmb_curso.Name = "cmb_curso";
            this.cmb_curso.Size = new System.Drawing.Size(129, 31);
            this.cmb_curso.TabIndex = 48;
            this.cmb_curso.Text = "Seleccione...";
            // 
            // dtp_Fingreso
            // 
            this.dtp_Fingreso.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.dtp_Fingreso.CalendarTitleForeColor = System.Drawing.Color.DarkCyan;
            this.dtp_Fingreso.CustomFormat = "";
            this.dtp_Fingreso.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_Fingreso.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fingreso.Location = new System.Drawing.Point(178, 87);
            this.dtp_Fingreso.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_Fingreso.Name = "dtp_Fingreso";
            this.dtp_Fingreso.Size = new System.Drawing.Size(171, 30);
            this.dtp_Fingreso.TabIndex = 49;
            this.dtp_Fingreso.Value = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            // 
            // dtp_fegreso
            // 
            this.dtp_fegreso.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.dtp_fegreso.CalendarTitleForeColor = System.Drawing.Color.DarkCyan;
            this.dtp_fegreso.CustomFormat = "";
            this.dtp_fegreso.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_fegreso.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fegreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fegreso.Location = new System.Drawing.Point(488, 325);
            this.dtp_fegreso.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_fegreso.Name = "dtp_fegreso";
            this.dtp_fegreso.Size = new System.Drawing.Size(171, 30);
            this.dtp_fegreso.TabIndex = 50;
            this.dtp_fegreso.Value = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            // 
            // dtp_Fretiro
            // 
            this.dtp_Fretiro.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.dtp_Fretiro.CalendarTitleForeColor = System.Drawing.Color.DarkCyan;
            this.dtp_Fretiro.CustomFormat = "";
            this.dtp_Fretiro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_Fretiro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fretiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fretiro.Location = new System.Drawing.Point(136, 325);
            this.dtp_Fretiro.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_Fretiro.Name = "dtp_Fretiro";
            this.dtp_Fretiro.Size = new System.Drawing.Size(171, 30);
            this.dtp_Fretiro.TabIndex = 51;
            this.dtp_Fretiro.Value = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            // 
            // dgv_Estudiantes
            // 
            this.dgv_Estudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Estudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Estudiantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Estudiantes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Estudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Estudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Estudiantes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Estudiantes.Location = new System.Drawing.Point(19, 518);
            this.dgv_Estudiantes.Name = "dgv_Estudiantes";
            this.dgv_Estudiantes.RowHeadersVisible = false;
            this.dgv_Estudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Estudiantes.Size = new System.Drawing.Size(729, 190);
            this.dgv_Estudiantes.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(417, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 52);
            this.button1.TabIndex = 53;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(417, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 52);
            this.button3.TabIndex = 54;
            this.button3.Text = "MODIFICAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(269, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 52);
            this.button4.TabIndex = 55;
            this.button4.Text = "SELECCIONAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmb_apoderado
            // 
            this.cmb_apoderado.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_apoderado.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_apoderado.FormattingEnabled = true;
            this.cmb_apoderado.Location = new System.Drawing.Point(269, 383);
            this.cmb_apoderado.Name = "cmb_apoderado";
            this.cmb_apoderado.Size = new System.Drawing.Size(337, 31);
            this.cmb_apoderado.TabIndex = 57;
            this.cmb_apoderado.Text = "Seleccione Comuna...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(148, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 56;
            this.label6.Text = "Apoderado";
            // 
            // Datos_Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 510);
            this.Controls.Add(this.cmb_apoderado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Estudiantes);
            this.Controls.Add(this.dtp_Fretiro);
            this.Controls.Add(this.dtp_fegreso);
            this.Controls.Add(this.dtp_Fingreso);
            this.Controls.Add(this.cmb_curso);
            this.Controls.Add(this.cmb_grado);
            this.Controls.Add(this.cmb_ensenanza);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_tipoal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_prof);
            this.Controls.Add(this.cmb_anio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Datos_Matricula";
            this.Text = "AgregarUs";
            this.Load += new System.EventHandler(this.AgregarDir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmb_anio;
        private System.Windows.Forms.ComboBox cmb_prof;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_tipoal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.ComboBox cmb_ensenanza;
        private System.Windows.Forms.ComboBox cmb_grado;
        private System.Windows.Forms.ComboBox cmb_curso;
        private System.Windows.Forms.DateTimePicker dtp_Fingreso;
        private System.Windows.Forms.DateTimePicker dtp_fegreso;
        private System.Windows.Forms.DateTimePicker dtp_Fretiro;
        private System.Windows.Forms.DataGridView dgv_Estudiantes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmb_apoderado;
        private System.Windows.Forms.Label label6;
    }
}