namespace SISTEMA_DE_MATRICULA_V1
{
    partial class Datos_Alumno
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rut_e = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_e = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_direccion_e = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.cmb_comuna = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_edad_e = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_salida = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_vivecon = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_fonoa = new System.Windows.Forms.TextBox();
            this.txt_fonob = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_proc_e = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_currepit_e = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_repitencia = new System.Windows.Forms.ComboBox();
            this.cmb_beneficio = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.matriculaDataSet = new SISTEMA_DE_MATRICULA_V1.matriculaDataSet();
            this.administradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administradoresTableAdapter = new SISTEMA_DE_MATRICULA_V1.matriculaDataSetTableAdapters.administradoresTableAdapter();
            this.matriculaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administradoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtp_Fnac_e = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_Estudiantes = new System.Windows.Forms.DataGridView();
            this.cmb_Nee = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.cmb_madre = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmb_padre = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmb_nacionalidad = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(733, 67);
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
            this.label1.Size = new System.Drawing.Size(318, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DEL ESTUDIANTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_rut_e
            // 
            this.txt_rut_e.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rut_e.Location = new System.Drawing.Point(60, 87);
            this.txt_rut_e.Name = "txt_rut_e";
            this.txt_rut_e.Size = new System.Drawing.Size(182, 30);
            this.txt_rut_e.TabIndex = 9;
            this.txt_rut_e.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(15, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre Completo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nombre_e
            // 
            this.txt_nombre_e.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_e.Location = new System.Drawing.Point(182, 151);
            this.txt_nombre_e.Name = "txt_nombre_e";
            this.txt_nombre_e.Size = new System.Drawing.Size(516, 30);
            this.txt_nombre_e.TabIndex = 11;
            this.txt_nombre_e.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(400, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Comuna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(400, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Genero";
            // 
            // txt_direccion_e
            // 
            this.txt_direccion_e.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion_e.Location = new System.Drawing.Point(108, 337);
            this.txt_direccion_e.Name = "txt_direccion_e";
            this.txt_direccion_e.Size = new System.Drawing.Size(590, 30);
            this.txt_direccion_e.TabIndex = 15;
            this.txt_direccion_e.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
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
            this.button2.Location = new System.Drawing.Point(565, 846);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 52);
            this.button2.TabIndex = 19;
            this.button2.Text = "GUARDAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(15, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Dirección";
            // 
            // cmb_genero
            // 
            this.cmb_genero.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_genero.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Location = new System.Drawing.Point(485, 87);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(213, 31);
            this.cmb_genero.TabIndex = 21;
            this.cmb_genero.Text = "Seleccione...";
            this.cmb_genero.SelectedIndexChanged += new System.EventHandler(this.combobox_tipo_SelectedIndexChanged);
            // 
            // cmb_comuna
            // 
            this.cmb_comuna.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_comuna.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_comuna.FormattingEnabled = true;
            this.cmb_comuna.Location = new System.Drawing.Point(485, 275);
            this.cmb_comuna.Name = "cmb_comuna";
            this.cmb_comuna.Size = new System.Drawing.Size(213, 31);
            this.cmb_comuna.TabIndex = 22;
            this.cmb_comuna.Text = "Seleccione...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(451, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Edad al 30 de Marzo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_edad_e
            // 
            this.txt_edad_e.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad_e.Location = new System.Drawing.Point(639, 215);
            this.txt_edad_e.Name = "txt_edad_e";
            this.txt_edad_e.Size = new System.Drawing.Size(59, 30);
            this.txt_edad_e.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(15, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Fecha de Nacimiento";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmb_salida
            // 
            this.cmb_salida.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_salida.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_salida.FormattingEnabled = true;
            this.cmb_salida.Location = new System.Drawing.Point(248, 401);
            this.cmb_salida.Name = "cmb_salida";
            this.cmb_salida.Size = new System.Drawing.Size(191, 31);
            this.cmb_salida.TabIndex = 28;
            this.cmb_salida.Text = "Seleccione...";
            this.cmb_salida.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(15, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "Salida del Establecimiento";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(15, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nacionalidad";
            // 
            // cmb_vivecon
            // 
            this.cmb_vivecon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vivecon.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_vivecon.FormattingEnabled = true;
            this.cmb_vivecon.Location = new System.Drawing.Point(545, 401);
            this.cmb_vivecon.Name = "cmb_vivecon";
            this.cmb_vivecon.Size = new System.Drawing.Size(152, 31);
            this.cmb_vivecon.TabIndex = 32;
            this.cmb_vivecon.Text = "Seleccione...";
            this.cmb_vivecon.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(459, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 23);
            this.label11.TabIndex = 31;
            this.label11.Text = "Vive con";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(15, 465);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 23);
            this.label12.TabIndex = 34;
            this.label12.Text = "Telefono Nº1";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txt_fonoa
            // 
            this.txt_fonoa.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fonoa.Location = new System.Drawing.Point(141, 462);
            this.txt_fonoa.Name = "txt_fonoa";
            this.txt_fonoa.Size = new System.Drawing.Size(180, 30);
            this.txt_fonoa.TabIndex = 33;
            // 
            // txt_fonob
            // 
            this.txt_fonob.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fonob.Location = new System.Drawing.Point(518, 462);
            this.txt_fonob.Name = "txt_fonob";
            this.txt_fonob.Size = new System.Drawing.Size(180, 30);
            this.txt_fonob.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(359, 465);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 23);
            this.label14.TabIndex = 37;
            this.label14.Text = "Telefono Nº2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(15, 531);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(274, 23);
            this.label13.TabIndex = 39;
            this.label13.Text = "Establecimiento de Procedencia";
            // 
            // txt_proc_e
            // 
            this.txt_proc_e.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proc_e.Location = new System.Drawing.Point(295, 528);
            this.txt_proc_e.Name = "txt_proc_e";
            this.txt_proc_e.Size = new System.Drawing.Size(403, 30);
            this.txt_proc_e.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(417, 593);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 23);
            this.label15.TabIndex = 43;
            this.label15.Text = "Curso Repetido";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txt_currepit_e
            // 
            this.txt_currepit_e.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currepit_e.Location = new System.Drawing.Point(560, 590);
            this.txt_currepit_e.Name = "txt_currepit_e";
            this.txt_currepit_e.Size = new System.Drawing.Size(137, 30);
            this.txt_currepit_e.TabIndex = 42;
            this.txt_currepit_e.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(15, 593);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 23);
            this.label16.TabIndex = 41;
            this.label16.Text = "Repitencia";
            // 
            // cmb_repitencia
            // 
            this.cmb_repitencia.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_repitencia.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_repitencia.FormattingEnabled = true;
            this.cmb_repitencia.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmb_repitencia.Location = new System.Drawing.Point(118, 590);
            this.cmb_repitencia.Name = "cmb_repitencia";
            this.cmb_repitencia.Size = new System.Drawing.Size(226, 31);
            this.cmb_repitencia.TabIndex = 44;
            this.cmb_repitencia.Text = "Seleccione...";
            // 
            // cmb_beneficio
            // 
            this.cmb_beneficio.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_beneficio.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_beneficio.FormattingEnabled = true;
            this.cmb_beneficio.Location = new System.Drawing.Point(114, 650);
            this.cmb_beneficio.Name = "cmb_beneficio";
            this.cmb_beneficio.Size = new System.Drawing.Size(248, 31);
            this.cmb_beneficio.TabIndex = 46;
            this.cmb_beneficio.Text = "Seleccione...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(15, 653);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 23);
            this.label17.TabIndex = 45;
            this.label17.Text = "Beneficios";
            // 
            // matriculaDataSet
            // 
            this.matriculaDataSet.DataSetName = "matriculaDataSet";
            this.matriculaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // administradoresBindingSource
            // 
            this.administradoresBindingSource.DataMember = "administradores";
            this.administradoresBindingSource.DataSource = this.matriculaDataSet;
            // 
            // administradoresTableAdapter
            // 
            this.administradoresTableAdapter.ClearBeforeFill = true;
            // 
            // matriculaDataSetBindingSource
            // 
            this.matriculaDataSetBindingSource.DataSource = this.matriculaDataSet;
            this.matriculaDataSetBindingSource.Position = 0;
            // 
            // administradoresBindingSource1
            // 
            this.administradoresBindingSource1.DataMember = "administradores";
            this.administradoresBindingSource1.DataSource = this.matriculaDataSetBindingSource;
            // 
            // dtp_Fnac_e
            // 
            this.dtp_Fnac_e.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.dtp_Fnac_e.CalendarTitleForeColor = System.Drawing.Color.DarkCyan;
            this.dtp_Fnac_e.CustomFormat = "";
            this.dtp_Fnac_e.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_Fnac_e.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fnac_e.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fnac_e.Location = new System.Drawing.Point(208, 220);
            this.dtp_Fnac_e.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_Fnac_e.Name = "dtp_Fnac_e";
            this.dtp_Fnac_e.Size = new System.Drawing.Size(171, 30);
            this.dtp_Fnac_e.TabIndex = 47;
            this.dtp_Fnac_e.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
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
            this.button1.Location = new System.Drawing.Point(277, 846);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 52);
            this.button1.TabIndex = 48;
            this.button1.Text = "SELECCIONAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgv_Estudiantes
            // 
            this.dgv_Estudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Estudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Estudiantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Estudiantes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Estudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Estudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Estudiantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Estudiantes.Location = new System.Drawing.Point(22, 919);
            this.dgv_Estudiantes.Name = "dgv_Estudiantes";
            this.dgv_Estudiantes.RowHeadersVisible = false;
            this.dgv_Estudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Estudiantes.Size = new System.Drawing.Size(585, 151);
            this.dgv_Estudiantes.TabIndex = 49;
            this.dgv_Estudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Estudiantes_CellContentClick);
            // 
            // cmb_Nee
            // 
            this.cmb_Nee.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Nee.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_Nee.FormattingEnabled = true;
            this.cmb_Nee.Items.AddRange(new object[] {
            "Sin",
            "Con"});
            this.cmb_Nee.Location = new System.Drawing.Point(570, 650);
            this.cmb_Nee.Name = "cmb_Nee";
            this.cmb_Nee.Size = new System.Drawing.Size(127, 31);
            this.cmb_Nee.TabIndex = 51;
            this.cmb_Nee.Text = "Seleccione...";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkCyan;
            this.label18.Location = new System.Drawing.Point(519, 653);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 23);
            this.label18.TabIndex = 50;
            this.label18.Text = "NEE";
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
            this.button4.Location = new System.Drawing.Point(417, 846);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 52);
            this.button4.TabIndex = 53;
            this.button4.Text = "MODIFICAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmb_madre
            // 
            this.cmb_madre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_madre.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_madre.FormattingEnabled = true;
            this.cmb_madre.Location = new System.Drawing.Point(96, 708);
            this.cmb_madre.Name = "cmb_madre";
            this.cmb_madre.Size = new System.Drawing.Size(601, 31);
            this.cmb_madre.TabIndex = 55;
            this.cmb_madre.Text = "Seleccione...";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkCyan;
            this.label19.Location = new System.Drawing.Point(27, 711);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 23);
            this.label19.TabIndex = 54;
            this.label19.Text = "Madre";
            // 
            // cmb_padre
            // 
            this.cmb_padre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_padre.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_padre.FormattingEnabled = true;
            this.cmb_padre.Location = new System.Drawing.Point(96, 766);
            this.cmb_padre.Name = "cmb_padre";
            this.cmb_padre.Size = new System.Drawing.Size(601, 31);
            this.cmb_padre.TabIndex = 57;
            this.cmb_padre.Text = "Seleccione...";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkCyan;
            this.label20.Location = new System.Drawing.Point(27, 769);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 23);
            this.label20.TabIndex = 56;
            this.label20.Text = "Padre";
            // 
            // cmb_nacionalidad
            // 
            this.cmb_nacionalidad.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nacionalidad.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_nacionalidad.Items.AddRange(new object[] {
            "Chilena",
            "Haitiana",
            "Colombiana",
            "Venezolana",
            "Argentina",
            "Peruana",
            "Bolibiana"});
            this.cmb_nacionalidad.Location = new System.Drawing.Point(141, 275);
            this.cmb_nacionalidad.Name = "cmb_nacionalidad";
            this.cmb_nacionalidad.Size = new System.Drawing.Size(213, 31);
            this.cmb_nacionalidad.TabIndex = 58;
            this.cmb_nacionalidad.Text = "Seleccione...";
            // 
            // Datos_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 510);
            this.Controls.Add(this.cmb_nacionalidad);
            this.Controls.Add(this.cmb_padre);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmb_madre);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmb_Nee);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dgv_Estudiantes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_Fnac_e);
            this.Controls.Add(this.cmb_beneficio);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmb_repitencia);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_currepit_e);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_proc_e);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_fonob);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_fonoa);
            this.Controls.Add(this.cmb_vivecon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_salida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_edad_e);
            this.Controls.Add(this.cmb_comuna);
            this.Controls.Add(this.cmb_genero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_direccion_e);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre_e);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_rut_e);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Datos_Alumno";
            this.Text = "DatosEstuduantes";
            this.Load += new System.EventHandler(this.AgregarDir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rut_e;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_e;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_direccion_e;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.ComboBox cmb_comuna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_edad_e;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_salida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_vivecon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_fonoa;
        private System.Windows.Forms.TextBox txt_fonob;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_proc_e;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_currepit_e;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_repitencia;
        private System.Windows.Forms.ComboBox cmb_beneficio;
        private System.Windows.Forms.Label label17;
        private matriculaDataSet matriculaDataSet;
        private System.Windows.Forms.BindingSource administradoresBindingSource;
        private matriculaDataSetTableAdapters.administradoresTableAdapter administradoresTableAdapter;
        private System.Windows.Forms.BindingSource matriculaDataSetBindingSource;
        private System.Windows.Forms.BindingSource administradoresBindingSource1;
        private System.Windows.Forms.DateTimePicker dtp_Fnac_e;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_Estudiantes;
        private System.Windows.Forms.ComboBox cmb_Nee;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmb_madre;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmb_padre;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmb_nacionalidad;
    }
}