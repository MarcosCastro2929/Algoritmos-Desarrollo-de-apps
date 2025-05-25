namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.practica_De_Inventario_De_ProductosDataSet = new CapaPresentacion.Practica_De_Inventario_De_ProductosDataSet();
            this.practicaDeInventarioDeProductosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practica_De_Inventario_De_ProductosDataSet1xd = new CapaPresentacion.Practica_De_Inventario_De_ProductosDataSet1xd();
            this.mostrarProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarProductosTableAdapter = new CapaPresentacion.Practica_De_Inventario_De_ProductosDataSet1xdTableAdapters.MostrarProductosTableAdapter();
            this.practicaDeInventarioDeProductosDataSet1xdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practica_De_Inventario_De_ProductosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDeInventarioDeProductosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practica_De_Inventario_De_ProductosDataSet1xd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDeInventarioDeProductosDataSet1xdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(325, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(142, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(142, 109);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(143, 20);
            this.txtDesc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(142, 163);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(143, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(142, 213);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(143, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(142, 273);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(143, 20);
            this.txtStock.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(350, 11);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(253, 35);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar:";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(43, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 34);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(163, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 34);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 76);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(317, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mantenimiento de productos";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.txtDesc);
            this.panel2.Controls.Add(this.txtMarca);
            this.panel2.Location = new System.Drawing.Point(2, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 336);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Location = new System.Drawing.Point(325, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 60);
            this.panel3.TabIndex = 16;
            // 
            // practica_De_Inventario_De_ProductosDataSet
            // 
            this.practica_De_Inventario_De_ProductosDataSet.DataSetName = "Practica_De_Inventario_De_ProductosDataSet";
            this.practica_De_Inventario_De_ProductosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // practicaDeInventarioDeProductosDataSetBindingSource
            // 
            this.practicaDeInventarioDeProductosDataSetBindingSource.DataSource = this.practica_De_Inventario_De_ProductosDataSet;
            this.practicaDeInventarioDeProductosDataSetBindingSource.Position = 0;
            // 
            // practica_De_Inventario_De_ProductosDataSet1xd
            // 
            this.practica_De_Inventario_De_ProductosDataSet1xd.DataSetName = "Practica_De_Inventario_De_ProductosDataSet1xd";
            this.practica_De_Inventario_De_ProductosDataSet1xd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarProductosBindingSource
            // 
            this.mostrarProductosBindingSource.DataMember = "MostrarProductos";
            this.mostrarProductosBindingSource.DataSource = this.practica_De_Inventario_De_ProductosDataSet1xd;
            // 
            // mostrarProductosTableAdapter
            // 
            this.mostrarProductosTableAdapter.ClearBeforeFill = true;
            // 
            // practicaDeInventarioDeProductosDataSet1xdBindingSource
            // 
            this.practicaDeInventarioDeProductosDataSet1xdBindingSource.DataSource = this.practica_De_Inventario_De_ProductosDataSet1xd;
            this.practicaDeInventarioDeProductosDataSet1xdBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 411);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.practica_De_Inventario_De_ProductosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDeInventarioDeProductosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practica_De_Inventario_De_ProductosDataSet1xd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDeInventarioDeProductosDataSet1xdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource practicaDeInventarioDeProductosDataSetBindingSource;
        private Practica_De_Inventario_De_ProductosDataSet practica_De_Inventario_De_ProductosDataSet;
        private Practica_De_Inventario_De_ProductosDataSet1xd practica_De_Inventario_De_ProductosDataSet1xd;
        private System.Windows.Forms.BindingSource mostrarProductosBindingSource;
        private Practica_De_Inventario_De_ProductosDataSet1xdTableAdapters.MostrarProductosTableAdapter mostrarProductosTableAdapter;
        private System.Windows.Forms.BindingSource practicaDeInventarioDeProductosDataSet1xdBindingSource;
    }
}

