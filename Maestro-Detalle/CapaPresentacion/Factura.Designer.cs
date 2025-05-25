namespace CapaPresentacion
{
    partial class Factura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spGenerarUltimaFactura2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemadeventa2DataSetDefinitivo3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_de_venta2DataSetDefinitivo3 = new CapaPresentacion.Sistema_de_venta2DataSetDefinitivo3();
            this.sistema_de_venta2DataSetFACTURA = new CapaPresentacion.Sistema_de_venta2DataSetFACTURA();
            this.sistemadeventa2DataSetFACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_de_venta2DataSetFactura2 = new CapaPresentacion.Sistema_de_venta2DataSetFactura2();
            this.sistemadeventa2DataSetFactura2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleTableAdapter = new CapaPresentacion.Sistema_de_venta2DataSetDefinitivo3TableAdapters.DetalleTableAdapter();
            this.spGenerarUltimaFactura2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GenerarUltimaFactura2TableAdapter = new CapaPresentacion.Sistema_de_venta2DataSetDefinitivo3TableAdapters.sp_GenerarUltimaFactura2TableAdapter();
            this.sistemadeventa2DataSetDefinitivo3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GenerarUltimaFactura2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetDefinitivo3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetDefinitivo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetFACTURA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetFACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetFactura2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetFactura2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetDefinitivo3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GenerarUltimaFactura2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spGenerarUltimaFactura2BindingSource1
            // 
            this.spGenerarUltimaFactura2BindingSource1.DataMember = "sp_GenerarUltimaFactura2";
            this.spGenerarUltimaFactura2BindingSource1.DataSource = this.sistemadeventa2DataSetDefinitivo3BindingSource;
            // 
            // sistemadeventa2DataSetDefinitivo3BindingSource
            // 
            this.sistemadeventa2DataSetDefinitivo3BindingSource.DataSource = this.sistema_de_venta2DataSetDefinitivo3;
            this.sistemadeventa2DataSetDefinitivo3BindingSource.Position = 0;
            // 
            // sistema_de_venta2DataSetDefinitivo3
            // 
            this.sistema_de_venta2DataSetDefinitivo3.DataSetName = "Sistema_de_venta2DataSetDefinitivo3";
            this.sistema_de_venta2DataSetDefinitivo3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistema_de_venta2DataSetFACTURA
            // 
            this.sistema_de_venta2DataSetFACTURA.DataSetName = "Sistema_de_venta2DataSetFACTURA";
            this.sistema_de_venta2DataSetFACTURA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemadeventa2DataSetFACTURABindingSource
            // 
            this.sistemadeventa2DataSetFACTURABindingSource.DataSource = this.sistema_de_venta2DataSetFACTURA;
            this.sistemadeventa2DataSetFACTURABindingSource.Position = 0;
            // 
            // sistema_de_venta2DataSetFactura2
            // 
            this.sistema_de_venta2DataSetFactura2.DataSetName = "Sistema_de_venta2DataSetFactura2";
            this.sistema_de_venta2DataSetFactura2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemadeventa2DataSetFactura2BindingSource
            // 
            this.sistemadeventa2DataSetFactura2BindingSource.DataSource = this.sistema_de_venta2DataSetFactura2;
            this.sistemadeventa2DataSetFactura2BindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "FacturaDefinitiva";
            reportDataSource1.Value = this.spGenerarUltimaFactura2BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.FacturaDefinitiva1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(711, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // detalleBindingSource
            // 
            this.detalleBindingSource.DataMember = "Detalle";
            this.detalleBindingSource.DataSource = this.sistemadeventa2DataSetDefinitivo3BindingSource;
            // 
            // detalleTableAdapter
            // 
            this.detalleTableAdapter.ClearBeforeFill = true;
            // 
            // spGenerarUltimaFactura2BindingSource
            // 
            this.spGenerarUltimaFactura2BindingSource.DataMember = "sp_GenerarUltimaFactura2";
            this.spGenerarUltimaFactura2BindingSource.DataSource = this.sistemadeventa2DataSetDefinitivo3BindingSource;
            // 
            // sp_GenerarUltimaFactura2TableAdapter
            // 
            this.sp_GenerarUltimaFactura2TableAdapter.ClearBeforeFill = true;
            // 
            // sistemadeventa2DataSetDefinitivo3BindingSource1
            // 
            this.sistemadeventa2DataSetDefinitivo3BindingSource1.DataSource = this.sistema_de_venta2DataSetDefinitivo3;
            this.sistemadeventa2DataSetDefinitivo3BindingSource1.Position = 0;
            // 
            // sp_GenerarUltimaFactura2BindingSource
            // 
            this.sp_GenerarUltimaFactura2BindingSource.DataMember = "sp_GenerarUltimaFactura2";
            this.sp_GenerarUltimaFactura2BindingSource.DataSource = this.sistema_de_venta2DataSetDefinitivo3;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 500);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetDefinitivo3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetDefinitivo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetFACTURA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetFACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetFactura2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetFactura2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetDefinitivo3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GenerarUltimaFactura2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sistemadeventa2DataSetFACTURABindingSource;
        private Sistema_de_venta2DataSetFACTURA sistema_de_venta2DataSetFACTURA;
        private System.Windows.Forms.BindingSource sistemadeventa2DataSetFactura2BindingSource;
        private Sistema_de_venta2DataSetFactura2 sistema_de_venta2DataSetFactura2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sistemadeventa2DataSetDefinitivo3BindingSource;
        private Sistema_de_venta2DataSetDefinitivo3 sistema_de_venta2DataSetDefinitivo3;
        private System.Windows.Forms.BindingSource detalleBindingSource;
        private Sistema_de_venta2DataSetDefinitivo3TableAdapters.DetalleTableAdapter detalleTableAdapter;
        private System.Windows.Forms.BindingSource spGenerarUltimaFactura2BindingSource;
        private Sistema_de_venta2DataSetDefinitivo3TableAdapters.sp_GenerarUltimaFactura2TableAdapter sp_GenerarUltimaFactura2TableAdapter;
        private System.Windows.Forms.BindingSource sistemadeventa2DataSetDefinitivo3BindingSource1;
        private System.Windows.Forms.BindingSource sp_GenerarUltimaFactura2BindingSource;
        private System.Windows.Forms.BindingSource spGenerarUltimaFactura2BindingSource1;
    }
}