namespace _04_Desafio_GUi
{
    partial class Form1
    {

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cboNombre = new ComboBox();
            dtgwFactura = new DataGridView();
            xd = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            Precio_unitario = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            btnLimpiar = new Button();
            lblNombre = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            txtPrecio = new TextBox();
            lblArticulos = new Label();
            lblTotalSub = new Label();
            lbl_Articulos = new Label();
            lbl_totalDeTotales = new Label();
            txtCantidad = new TextBox();
            tbcForm = new TabControl();
            tbpForm = new TabPage();
            lblFormulario = new Label();
            panel1 = new Panel();
            tbpInfo = new TabPage();
            lblInformacion = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgwFactura).BeginInit();
            tbcForm.SuspendLayout();
            tbpForm.SuspendLayout();
            panel1.SuspendLayout();
            tbpInfo.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9.75F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(65, 84);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 0;
            label1.Text = "Cantidad: ";
            // 
            // cboNombre
            // 
            cboNombre.BackColor = Color.WhiteSmoke;
            cboNombre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNombre.FormattingEnabled = true;
            cboNombre.Items.AddRange(new object[] { "Ajo", "Verdura", "Zanahoria" });
            cboNombre.Location = new Point(65, 45);
            cboNombre.Name = "cboNombre";
            cboNombre.Size = new Size(329, 23);
            cboNombre.TabIndex = 1;
            // 
            // dtgwFactura
            // 
            dtgwFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwFactura.Columns.AddRange(new DataGridViewColumn[] { xd, cantidad, Precio_unitario, Subtotal, Total });
            dtgwFactura.GridColor = Color.Black;
            dtgwFactura.Location = new Point(179, 276);
            dtgwFactura.Name = "dtgwFactura";
            dtgwFactura.Size = new Size(463, 200);
            dtgwFactura.TabIndex = 2;
            dtgwFactura.CellContentClick += dtgwFactura_CellContentClick;
            // 
            // xd
            // 
            xd.HeaderText = "Nombre";
            xd.Name = "xd";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.Width = 70;
            // 
            // Precio_unitario
            // 
            Precio_unitario.HeaderText = "Precio_Unitario";
            Precio_unitario.Name = "Precio_unitario";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 70;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 80;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaption;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(566, 482);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 33);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaption;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Arial Rounded MT Bold", 9F);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(179, 482);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(84, 33);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnEliminar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Century Gothic", 9.75F);
            lblNombre.ForeColor = SystemColors.ActiveCaptionText;
            lblNombre.Location = new Point(65, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 17);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9.75F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(265, 84);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 8;
            label2.Text = "Precio:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(123, 153);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(215, 32);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(265, 104);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(129, 23);
            txtPrecio.TabIndex = 11;
            // 
            // lblArticulos
            // 
            lblArticulos.AutoSize = true;
            lblArticulos.BackColor = Color.Transparent;
            lblArticulos.Font = new Font("Century Gothic", 15.75F);
            lblArticulos.ForeColor = SystemColors.ActiveCaptionText;
            lblArticulos.Location = new Point(65, 19);
            lblArticulos.Name = "lblArticulos";
            lblArticulos.Size = new Size(236, 24);
            lblArticulos.TabIndex = 14;
            lblArticulos.Text = "Articulo Seleccionado";
            // 
            // lblTotalSub
            // 
            lblTotalSub.AutoSize = true;
            lblTotalSub.BackColor = Color.Transparent;
            lblTotalSub.Font = new Font("Century Gothic", 15.75F);
            lblTotalSub.ForeColor = SystemColors.ActiveCaptionText;
            lblTotalSub.Location = new Point(87, 21);
            lblTotalSub.Name = "lblTotalSub";
            lblTotalSub.Size = new Size(170, 24);
            lblTotalSub.TabIndex = 16;
            lblTotalSub.Text = "Total y sub-total";
            lblTotalSub.Click += label3_Click;
            // 
            // lbl_Articulos
            // 
            lbl_Articulos.AutoSize = true;
            lbl_Articulos.BackColor = Color.Transparent;
            lbl_Articulos.Font = new Font("Century Gothic", 9.75F);
            lbl_Articulos.ForeColor = SystemColors.ActiveCaptionText;
            lbl_Articulos.Location = new Point(65, 86);
            lbl_Articulos.Name = "lbl_Articulos";
            lbl_Articulos.Size = new Size(0, 17);
            lbl_Articulos.TabIndex = 17;
            // 
            // lbl_totalDeTotales
            // 
            lbl_totalDeTotales.AutoSize = true;
            lbl_totalDeTotales.BackColor = Color.Transparent;
            lbl_totalDeTotales.Font = new Font("Century Gothic", 9.75F);
            lbl_totalDeTotales.ForeColor = SystemColors.ActiveCaptionText;
            lbl_totalDeTotales.Location = new Point(87, 76);
            lbl_totalDeTotales.Name = "lbl_totalDeTotales";
            lbl_totalDeTotales.Size = new Size(0, 17);
            lbl_totalDeTotales.TabIndex = 18;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.White;
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.ForeColor = Color.Black;
            txtCantidad.Location = new Point(65, 104);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(129, 23);
            txtCantidad.TabIndex = 19;
            txtCantidad.TextChanged += textBox1_TextChanged;
            // 
            // tbcForm
            // 
            tbcForm.Controls.Add(tbpForm);
            tbcForm.Controls.Add(tbpInfo);
            tbcForm.Dock = DockStyle.Fill;
            tbcForm.Location = new Point(0, 0);
            tbcForm.Name = "tbcForm";
            tbcForm.RightToLeft = RightToLeft.No;
            tbcForm.RightToLeftLayout = true;
            tbcForm.SelectedIndex = 0;
            tbcForm.Size = new Size(852, 560);
            tbcForm.TabIndex = 20;
            // 
            // tbpForm
            // 
            tbpForm.BackColor = Color.Gray;
            tbpForm.Controls.Add(lblFormulario);
            tbpForm.Controls.Add(panel1);
            tbpForm.Controls.Add(dtgwFactura);
            tbpForm.Controls.Add(btnSalir);
            tbpForm.Controls.Add(btnLimpiar);
            tbpForm.Location = new Point(4, 24);
            tbpForm.Name = "tbpForm";
            tbpForm.Padding = new Padding(3);
            tbpForm.Size = new Size(844, 532);
            tbpForm.TabIndex = 0;
            tbpForm.Text = "Formulario";
            tbpForm.Click += tabPage1_Click;
            // 
            // lblFormulario
            // 
            lblFormulario.AutoSize = true;
            lblFormulario.BackColor = Color.Transparent;
            lblFormulario.Font = new Font("Century Gothic", 25.75F);
            lblFormulario.ForeColor = SystemColors.ActiveCaption;
            lblFormulario.Location = new Point(328, 12);
            lblFormulario.Name = "lblFormulario";
            lblFormulario.Size = new Size(160, 42);
            lblFormulario.TabIndex = 21;
            lblFormulario.Text = "Articulos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtPrecio);
            panel1.Location = new Point(179, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 206);
            panel1.TabIndex = 20;
            // 
            // tbpInfo
            // 
            tbpInfo.BackColor = Color.Gray;
            tbpInfo.Controls.Add(lblInformacion);
            tbpInfo.Controls.Add(panel2);
            tbpInfo.Controls.Add(panel3);
            tbpInfo.Location = new Point(4, 24);
            tbpInfo.Name = "tbpInfo";
            tbpInfo.Padding = new Padding(3);
            tbpInfo.Size = new Size(844, 532);
            tbpInfo.TabIndex = 1;
            tbpInfo.Text = "Informacion";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.BackColor = Color.Transparent;
            lblInformacion.Font = new Font("Century Gothic", 25.75F);
            lblInformacion.ForeColor = Color.LightSkyBlue;
            lblInformacion.Location = new Point(312, 23);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(232, 42);
            lblInformacion.TabIndex = 19;
            lblInformacion.Text = "Informacion ";
            lblInformacion.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblArticulos);
            panel2.Controls.Add(lbl_Articulos);
            panel2.ForeColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(246, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 142);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblTotalSub);
            panel3.Controls.Add(lbl_totalDeTotales);
            panel3.ForeColor = SystemColors.ControlDark;
            panel3.Location = new Point(246, 271);
            panel3.Name = "panel3";
            panel3.Size = new Size(351, 149);
            panel3.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(852, 560);
            Controls.Add(tbcForm);
            Name = "Form1";
            Text = "Carrito de articulos electronicos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgwFactura).EndInit();
            tbcForm.ResumeLayout(false);
            tbpForm.ResumeLayout(false);
            tbpForm.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tbpInfo.ResumeLayout(false);
            tbpInfo.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cboNombre;
        private DataGridView dtgwFactura;
        private Button btnSalir;
        private Button btnLimpiar;
        private Label lblNombre;
        private Label label2;
        private Button btnAgregar;
        private TextBox txtPrecio;
        private Label lblArticulos;
        private Label lblTotalSub;
        private Label lbl_Articulos;
        private Label lbl_totalDeTotales;
        private TextBox txtCantidad;
        private TabControl tbcForm;
        private TabPage tbpForm;
        private TabPage tbpInfo;
        private DataGridViewTextBoxColumn xd;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn Precio_unitario;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Total;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblInformacion;
        private Label lblFormulario;
    }
}
