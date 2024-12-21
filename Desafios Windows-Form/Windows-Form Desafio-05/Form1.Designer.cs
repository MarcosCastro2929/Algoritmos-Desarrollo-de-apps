namespace _05_Desafio_GUi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbcInformacion = new TabControl();
            tbpEmpleado = new TabPage();
            panel2 = new Panel();
            label1 = new Label();
            btn_Salir = new Button();
            panel1 = new Panel();
            txt_NHijos = new TextBox();
            txt_Sueldo = new TextBox();
            txt_Cargo = new TextBox();
            btn_Calcular = new Button();
            lbl_Nhijos = new Label();
            lbl_Sueldo = new Label();
            lbl_Cargo = new Label();
            txt_Nombre = new TextBox();
            lblNombre = new Label();
            panel3 = new Panel();
            txt_incentivo = new TextBox();
            btn_Limpiar = new Button();
            btn_Guardar = new Button();
            lbl_incentivo = new Label();
            lbl_AFP = new Label();
            lbl_SFS = new Label();
            lbl_ISR = new Label();
            txt_Otro = new TextBox();
            lbl_Otro = new Label();
            txt_Sueldoneto = new TextBox();
            txt_AFP = new TextBox();
            txt_Totaldesc = new TextBox();
            txt_SFS = new TextBox();
            lblSueldoNeto = new Label();
            txt_SueldoIncentivo = new TextBox();
            lbl_TotalDesc = new Label();
            txt_ISR = new TextBox();
            lbl_Sueldoincentivos = new Label();
            tbpInfo = new TabPage();
            button1 = new Button();
            btn_edit = new Button();
            btnGenerar = new Button();
            dtgw_Info = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            Incentivo = new DataGridViewTextBoxColumn();
            sueldoIncentivo = new DataGridViewTextBoxColumn();
            AFP = new DataGridViewTextBoxColumn();
            SFS = new DataGridViewTextBoxColumn();
            ISR = new DataGridViewTextBoxColumn();
            OTROS = new DataGridViewTextBoxColumn();
            Total_descuento = new DataGridViewTextBoxColumn();
            Sueldo_Neto = new DataGridViewTextBoxColumn();
            tbcInformacion.SuspendLayout();
            tbpEmpleado.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tbpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgw_Info).BeginInit();
            SuspendLayout();
            // 
            // tbcInformacion
            // 
            tbcInformacion.Controls.Add(tbpEmpleado);
            tbcInformacion.Controls.Add(tbpInfo);
            tbcInformacion.Dock = DockStyle.Fill;
            tbcInformacion.Location = new Point(0, 0);
            tbcInformacion.Name = "tbcInformacion";
            tbcInformacion.SelectedIndex = 0;
            tbcInformacion.Size = new Size(1074, 678);
            tbcInformacion.TabIndex = 0;
            // 
            // tbpEmpleado
            // 
            tbpEmpleado.BackColor = Color.FromArgb(5, 3, 25);
            tbpEmpleado.Controls.Add(panel2);
            tbpEmpleado.Controls.Add(panel1);
            tbpEmpleado.Controls.Add(panel3);
            tbpEmpleado.Location = new Point(4, 24);
            tbpEmpleado.Name = "tbpEmpleado";
            tbpEmpleado.Padding = new Padding(3);
            tbpEmpleado.Size = new Size(1066, 650);
            tbpEmpleado.TabIndex = 0;
            tbpEmpleado.Text = "Empleado";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 38, 87);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_Salir);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1063, 66);
            panel2.TabIndex = 35;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(326, 13);
            label1.Name = "label1";
            label1.Size = new Size(430, 33);
            label1.TabIndex = 34;
            label1.Text = "Ingrese los datos del empleado";
            // 
            // btn_Salir
            // 
            btn_Salir.BackgroundImageLayout = ImageLayout.Center;
            btn_Salir.FlatStyle = FlatStyle.Flat;
            btn_Salir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Salir.ForeColor = Color.White;
            btn_Salir.Location = new Point(997, 13);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(57, 41);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 58, 118);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_NHijos);
            panel1.Controls.Add(txt_Sueldo);
            panel1.Controls.Add(txt_Cargo);
            panel1.Controls.Add(btn_Calcular);
            panel1.Controls.Add(lbl_Nhijos);
            panel1.Controls.Add(lbl_Sueldo);
            panel1.Controls.Add(lbl_Cargo);
            panel1.Controls.Add(txt_Nombre);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(174, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 202);
            panel1.TabIndex = 34;
            // 
            // txt_NHijos
            // 
            txt_NHijos.BackColor = Color.FromArgb(34, 51, 102);
            txt_NHijos.ForeColor = Color.White;
            txt_NHijos.Location = new Point(430, 101);
            txt_NHijos.Name = "txt_NHijos";
            txt_NHijos.Size = new Size(216, 23);
            txt_NHijos.TabIndex = 15;
            // 
            // txt_Sueldo
            // 
            txt_Sueldo.BackColor = Color.FromArgb(34, 51, 102);
            txt_Sueldo.ForeColor = Color.White;
            txt_Sueldo.Location = new Point(430, 39);
            txt_Sueldo.Name = "txt_Sueldo";
            txt_Sueldo.Size = new Size(216, 23);
            txt_Sueldo.TabIndex = 14;
            // 
            // txt_Cargo
            // 
            txt_Cargo.BackColor = Color.FromArgb(34, 51, 102);
            txt_Cargo.ForeColor = Color.White;
            txt_Cargo.Location = new Point(67, 101);
            txt_Cargo.Name = "txt_Cargo";
            txt_Cargo.Size = new Size(214, 23);
            txt_Cargo.TabIndex = 13;
            txt_Cargo.TextChanged += txt_Cargo_TextChanged;
            // 
            // btn_Calcular
            // 
            btn_Calcular.BackColor = SystemColors.MenuHighlight;
            btn_Calcular.FlatStyle = FlatStyle.Flat;
            btn_Calcular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calcular.ForeColor = Color.White;
            btn_Calcular.Location = new Point(221, 147);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(282, 34);
            btn_Calcular.TabIndex = 31;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = false;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // lbl_Nhijos
            // 
            lbl_Nhijos.AutoSize = true;
            lbl_Nhijos.BackColor = Color.Transparent;
            lbl_Nhijos.Font = new Font("Century Gothic", 12F);
            lbl_Nhijos.ForeColor = Color.White;
            lbl_Nhijos.Location = new Point(430, 76);
            lbl_Nhijos.Name = "lbl_Nhijos";
            lbl_Nhijos.Size = new Size(43, 21);
            lbl_Nhijos.TabIndex = 5;
            lbl_Nhijos.Text = "Hijos";
            lbl_Nhijos.Click += label4_Click;
            // 
            // lbl_Sueldo
            // 
            lbl_Sueldo.AutoSize = true;
            lbl_Sueldo.Font = new Font("Century Gothic", 12F);
            lbl_Sueldo.ForeColor = SystemColors.Control;
            lbl_Sueldo.Location = new Point(430, 15);
            lbl_Sueldo.Name = "lbl_Sueldo";
            lbl_Sueldo.Size = new Size(62, 21);
            lbl_Sueldo.TabIndex = 4;
            lbl_Sueldo.Text = "Sueldo";
            // 
            // lbl_Cargo
            // 
            lbl_Cargo.AutoSize = true;
            lbl_Cargo.Font = new Font("Century Gothic", 12F);
            lbl_Cargo.ForeColor = SystemColors.Control;
            lbl_Cargo.Location = new Point(70, 76);
            lbl_Cargo.Name = "lbl_Cargo";
            lbl_Cargo.Size = new Size(60, 21);
            lbl_Cargo.TabIndex = 3;
            lbl_Cargo.Text = "Cargo";
            lbl_Cargo.Click += label2_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.FromArgb(34, 51, 102);
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(70, 39);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(214, 23);
            txt_Nombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(70, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(10, 43, 88);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txt_incentivo);
            panel3.Controls.Add(btn_Limpiar);
            panel3.Controls.Add(btn_Guardar);
            panel3.Controls.Add(lbl_incentivo);
            panel3.Controls.Add(lbl_AFP);
            panel3.Controls.Add(lbl_SFS);
            panel3.Controls.Add(lbl_ISR);
            panel3.Controls.Add(txt_Otro);
            panel3.Controls.Add(lbl_Otro);
            panel3.Controls.Add(txt_Sueldoneto);
            panel3.Controls.Add(txt_AFP);
            panel3.Controls.Add(txt_Totaldesc);
            panel3.Controls.Add(txt_SFS);
            panel3.Controls.Add(lblSueldoNeto);
            panel3.Controls.Add(txt_SueldoIncentivo);
            panel3.Controls.Add(lbl_TotalDesc);
            panel3.Controls.Add(txt_ISR);
            panel3.Controls.Add(lbl_Sueldoincentivos);
            panel3.Location = new Point(174, 271);
            panel3.Name = "panel3";
            panel3.Size = new Size(723, 371);
            panel3.TabIndex = 35;
            // 
            // txt_incentivo
            // 
            txt_incentivo.BackColor = Color.FromArgb(10, 43, 88);
            txt_incentivo.ForeColor = Color.White;
            txt_incentivo.Location = new Point(123, 186);
            txt_incentivo.Name = "txt_incentivo";
            txt_incentivo.ReadOnly = true;
            txt_incentivo.Size = new Size(179, 23);
            txt_incentivo.TabIndex = 32;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.FlatStyle = FlatStyle.Flat;
            btn_Limpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpiar.ForeColor = Color.White;
            btn_Limpiar.Location = new Point(160, 314);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(124, 37);
            btn_Limpiar.TabIndex = 27;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.FlatStyle = FlatStyle.Flat;
            btn_Guardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Guardar.ForeColor = Color.White;
            btn_Guardar.Location = new Point(435, 314);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(121, 37);
            btn_Guardar.TabIndex = 25;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // lbl_incentivo
            // 
            lbl_incentivo.AutoSize = true;
            lbl_incentivo.BackColor = Color.Transparent;
            lbl_incentivo.Font = new Font("Century Gothic", 12F);
            lbl_incentivo.ForeColor = Color.White;
            lbl_incentivo.Location = new Point(123, 162);
            lbl_incentivo.Name = "lbl_incentivo";
            lbl_incentivo.Size = new Size(85, 21);
            lbl_incentivo.TabIndex = 33;
            lbl_incentivo.Text = "Incentivo";
            // 
            // lbl_AFP
            // 
            lbl_AFP.AutoSize = true;
            lbl_AFP.Font = new Font("Century Gothic", 12F);
            lbl_AFP.ForeColor = Color.White;
            lbl_AFP.Location = new Point(123, 23);
            lbl_AFP.Name = "lbl_AFP";
            lbl_AFP.Size = new Size(40, 21);
            lbl_AFP.TabIndex = 7;
            lbl_AFP.Text = "AFP";
            lbl_AFP.Click += label6_Click;
            // 
            // lbl_SFS
            // 
            lbl_SFS.AutoSize = true;
            lbl_SFS.Font = new Font("Century Gothic", 12F);
            lbl_SFS.ForeColor = Color.White;
            lbl_SFS.Location = new Point(412, 23);
            lbl_SFS.Name = "lbl_SFS";
            lbl_SFS.Size = new Size(34, 21);
            lbl_SFS.TabIndex = 8;
            lbl_SFS.Text = "SFS";
            // 
            // lbl_ISR
            // 
            lbl_ISR.AutoSize = true;
            lbl_ISR.Font = new Font("Century Gothic", 12F);
            lbl_ISR.ForeColor = Color.White;
            lbl_ISR.Location = new Point(123, 93);
            lbl_ISR.Name = "lbl_ISR";
            lbl_ISR.Size = new Size(33, 21);
            lbl_ISR.TabIndex = 9;
            lbl_ISR.Text = "ISR";
            // 
            // txt_Otro
            // 
            txt_Otro.BackColor = Color.FromArgb(10, 43, 88);
            txt_Otro.ForeColor = Color.White;
            txt_Otro.Location = new Point(412, 119);
            txt_Otro.Name = "txt_Otro";
            txt_Otro.ReadOnly = true;
            txt_Otro.Size = new Size(173, 23);
            txt_Otro.TabIndex = 22;
            // 
            // lbl_Otro
            // 
            lbl_Otro.AutoSize = true;
            lbl_Otro.Font = new Font("Century Gothic", 12F);
            lbl_Otro.ForeColor = Color.White;
            lbl_Otro.Location = new Point(412, 93);
            lbl_Otro.Name = "lbl_Otro";
            lbl_Otro.Size = new Size(46, 21);
            lbl_Otro.TabIndex = 10;
            lbl_Otro.Text = "Otro";
            // 
            // txt_Sueldoneto
            // 
            txt_Sueldoneto.BackColor = Color.FromArgb(10, 43, 88);
            txt_Sueldoneto.ForeColor = Color.White;
            txt_Sueldoneto.Location = new Point(412, 255);
            txt_Sueldoneto.Name = "txt_Sueldoneto";
            txt_Sueldoneto.ReadOnly = true;
            txt_Sueldoneto.Size = new Size(173, 23);
            txt_Sueldoneto.TabIndex = 24;
            // 
            // txt_AFP
            // 
            txt_AFP.BackColor = Color.FromArgb(10, 43, 88);
            txt_AFP.ForeColor = Color.White;
            txt_AFP.Location = new Point(123, 49);
            txt_AFP.Name = "txt_AFP";
            txt_AFP.ReadOnly = true;
            txt_AFP.Size = new Size(179, 23);
            txt_AFP.TabIndex = 19;
            // 
            // txt_Totaldesc
            // 
            txt_Totaldesc.BackColor = Color.FromArgb(10, 43, 88);
            txt_Totaldesc.ForeColor = Color.White;
            txt_Totaldesc.Location = new Point(412, 186);
            txt_Totaldesc.Name = "txt_Totaldesc";
            txt_Totaldesc.ReadOnly = true;
            txt_Totaldesc.Size = new Size(173, 23);
            txt_Totaldesc.TabIndex = 23;
            // 
            // txt_SFS
            // 
            txt_SFS.BackColor = Color.FromArgb(10, 43, 88);
            txt_SFS.ForeColor = Color.White;
            txt_SFS.Location = new Point(412, 49);
            txt_SFS.Name = "txt_SFS";
            txt_SFS.ReadOnly = true;
            txt_SFS.Size = new Size(173, 23);
            txt_SFS.TabIndex = 20;
            // 
            // lblSueldoNeto
            // 
            lblSueldoNeto.AutoSize = true;
            lblSueldoNeto.Font = new Font("Century Gothic", 12F);
            lblSueldoNeto.ForeColor = Color.White;
            lblSueldoNeto.Location = new Point(412, 231);
            lblSueldoNeto.Name = "lblSueldoNeto";
            lblSueldoNeto.Size = new Size(105, 21);
            lblSueldoNeto.TabIndex = 12;
            lblSueldoNeto.Text = "Sueldo Neto";
            // 
            // txt_SueldoIncentivo
            // 
            txt_SueldoIncentivo.BackColor = Color.FromArgb(10, 43, 88);
            txt_SueldoIncentivo.ForeColor = Color.White;
            txt_SueldoIncentivo.Location = new Point(123, 255);
            txt_SueldoIncentivo.Name = "txt_SueldoIncentivo";
            txt_SueldoIncentivo.ReadOnly = true;
            txt_SueldoIncentivo.Size = new Size(179, 23);
            txt_SueldoIncentivo.TabIndex = 16;
            // 
            // lbl_TotalDesc
            // 
            lbl_TotalDesc.AutoSize = true;
            lbl_TotalDesc.Font = new Font("Century Gothic", 12F);
            lbl_TotalDesc.ForeColor = Color.White;
            lbl_TotalDesc.Location = new Point(412, 162);
            lbl_TotalDesc.Name = "lbl_TotalDesc";
            lbl_TotalDesc.Size = new Size(91, 21);
            lbl_TotalDesc.TabIndex = 11;
            lbl_TotalDesc.Text = "Total Desc";
            // 
            // txt_ISR
            // 
            txt_ISR.BackColor = Color.FromArgb(10, 43, 88);
            txt_ISR.ForeColor = Color.White;
            txt_ISR.Location = new Point(123, 119);
            txt_ISR.Name = "txt_ISR";
            txt_ISR.ReadOnly = true;
            txt_ISR.Size = new Size(179, 23);
            txt_ISR.TabIndex = 21;
            // 
            // lbl_Sueldoincentivos
            // 
            lbl_Sueldoincentivos.AutoSize = true;
            lbl_Sueldoincentivos.Font = new Font("Century Gothic", 12F);
            lbl_Sueldoincentivos.ForeColor = Color.White;
            lbl_Sueldoincentivos.Location = new Point(123, 231);
            lbl_Sueldoincentivos.Name = "lbl_Sueldoincentivos";
            lbl_Sueldoincentivos.Size = new Size(152, 21);
            lbl_Sueldoincentivos.TabIndex = 6;
            lbl_Sueldoincentivos.Text = "Sueldo+Incentivos";
            // 
            // tbpInfo
            // 
            tbpInfo.BackColor = Color.FromArgb(5, 3, 25);
            tbpInfo.Controls.Add(button1);
            tbpInfo.Controls.Add(btn_edit);
            tbpInfo.Controls.Add(btnGenerar);
            tbpInfo.Controls.Add(dtgw_Info);
            tbpInfo.Location = new Point(4, 24);
            tbpInfo.Name = "tbpInfo";
            tbpInfo.Padding = new Padding(3);
            tbpInfo.Size = new Size(1066, 650);
            tbpInfo.TabIndex = 1;
            tbpInfo.Text = "Informaciones";
            tbpInfo.Click += tabPage2_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1003, 6);
            button1.Name = "button1";
            button1.Size = new Size(55, 33);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(96, 0, 31);
            btn_edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 0, 20);
            btn_edit.FlatStyle = FlatStyle.Popup;
            btn_edit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(747, 498);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(105, 47);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Editar";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(51, 101, 85);
            btnGenerar.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 101, 75);
            btnGenerar.FlatStyle = FlatStyle.Popup;
            btnGenerar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(869, 498);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(105, 47);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += button1_Click;
            // 
            // dtgw_Info
            // 
            dtgw_Info.BackgroundColor = Color.FromArgb(51, 51, 51);
            dtgw_Info.BorderStyle = BorderStyle.Fixed3D;
            dtgw_Info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgw_Info.Columns.AddRange(new DataGridViewColumn[] { Nombre, Sueldo, Incentivo, sueldoIncentivo, AFP, SFS, ISR, OTROS, Total_descuento, Sueldo_Neto });
            dtgw_Info.Location = new Point(90, 131);
            dtgw_Info.Name = "dtgw_Info";
            dtgw_Info.ReadOnly = true;
            dtgw_Info.Size = new Size(884, 341);
            dtgw_Info.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Sueldo
            // 
            Sueldo.HeaderText = "Sueldo";
            Sueldo.Name = "Sueldo";
            Sueldo.ReadOnly = true;
            Sueldo.Width = 70;
            // 
            // Incentivo
            // 
            Incentivo.HeaderText = "Incentivo";
            Incentivo.Name = "Incentivo";
            Incentivo.ReadOnly = true;
            Incentivo.Width = 70;
            // 
            // sueldoIncentivo
            // 
            sueldoIncentivo.HeaderText = "Sueldo_+_Incentivo";
            sueldoIncentivo.Name = "sueldoIncentivo";
            sueldoIncentivo.ReadOnly = true;
            sueldoIncentivo.Width = 120;
            // 
            // AFP
            // 
            AFP.HeaderText = "AFP";
            AFP.Name = "AFP";
            AFP.ReadOnly = true;
            AFP.Width = 60;
            // 
            // SFS
            // 
            SFS.HeaderText = "SFS";
            SFS.Name = "SFS";
            SFS.ReadOnly = true;
            SFS.Width = 60;
            // 
            // ISR
            // 
            ISR.HeaderText = "ISR";
            ISR.Name = "ISR";
            ISR.ReadOnly = true;
            ISR.Width = 70;
            // 
            // OTROS
            // 
            OTROS.HeaderText = "OTROS";
            OTROS.Name = "OTROS";
            OTROS.ReadOnly = true;
            OTROS.Width = 50;
            // 
            // Total_descuento
            // 
            Total_descuento.HeaderText = "Total descuento";
            Total_descuento.Name = "Total_descuento";
            Total_descuento.ReadOnly = true;
            Total_descuento.Width = 120;
            // 
            // Sueldo_Neto
            // 
            Sueldo_Neto.HeaderText = "Sueldo Neto";
            Sueldo_Neto.Name = "Sueldo_Neto";
            Sueldo_Neto.ReadOnly = true;
            Sueldo_Neto.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 678);
            Controls.Add(tbcInformacion);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            tbcInformacion.ResumeLayout(false);
            tbpEmpleado.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tbpInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgw_Info).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcInformacion;
        private TabPage tbpEmpleado;
        private TabPage tbpInfo;
        private DataGridView dtgw_Info;
        private Button btn_Salir;
        private TextBox txt_Nombre;
        private Label lblNombre;
        private Button btnGenerar;
        private Label lblSueldoNeto;
        private Label lbl_TotalDesc;
        private Label lbl_Otro;
        private Label lbl_ISR;
        private Label lbl_SFS;
        private Label lbl_AFP;
        private Label lbl_Sueldoincentivos;
        private Label lbl_Nhijos;
        private Label lbl_Sueldo;
        private Label lbl_Cargo;
        private TextBox txt_SueldoIncentivo;
        private TextBox txt_NHijos;
        private TextBox txt_Sueldo;
        private TextBox txt_Cargo;
        private TextBox txt_Sueldoneto;
        private TextBox txt_Totaldesc;
        private TextBox txt_Otro;
        private TextBox txt_ISR;
        private TextBox txt_SFS;
        private TextBox txt_AFP;
        private Button btn_Limpiar;
        private Button btn_Guardar;
        private Button btn_Calcular;
        private Label lbl_incentivo;
        private TextBox txt_incentivo;
        private Button btn_edit;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Sueldo;
        private DataGridViewTextBoxColumn Incentivo;
        private DataGridViewTextBoxColumn sueldoIncentivo;
        private DataGridViewTextBoxColumn AFP;
        private DataGridViewTextBoxColumn SFS;
        private DataGridViewTextBoxColumn ISR;
        private DataGridViewTextBoxColumn OTROS;
        private DataGridViewTextBoxColumn Total_descuento;
        private DataGridViewTextBoxColumn Sueldo_Neto;
    }
}
