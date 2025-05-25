namespace CapaPresentacion
{
    partial class ejemplo_reporting
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
            this.mostrarProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practica_De_Inventario_De_ProductosDataSet = new CapaPresentacion.Practica_De_Inventario_De_ProductosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrarProductosTableAdapter = new CapaPresentacion.Practica_De_Inventario_De_ProductosDataSetTableAdapters.MostrarProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practica_De_Inventario_De_ProductosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarProductosBindingSource
            // 
            this.mostrarProductosBindingSource.DataMember = "MostrarProductos";
            this.mostrarProductosBindingSource.DataSource = this.practica_De_Inventario_De_ProductosDataSet;
            // 
            // practica_De_Inventario_De_ProductosDataSet
            // 
            this.practica_De_Inventario_De_ProductosDataSet.DataSetName = "Practica_De_Inventario_De_ProductosDataSet";
            this.practica_De_Inventario_De_ProductosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Reporte_mostrar_Productos1";
            reportDataSource1.Value = this.mostrarProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // mostrarProductosTableAdapter
            // 
            this.mostrarProductosTableAdapter.ClearBeforeFill = true;
            // 
            // ejemplo_reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ejemplo_reporting";
            this.Text = "ejemplo_reporting";
            this.Load += new System.EventHandler(this.ejemplo_reporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practica_De_Inventario_De_ProductosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Practica_De_Inventario_De_ProductosDataSet practica_De_Inventario_De_ProductosDataSet;
        private System.Windows.Forms.BindingSource mostrarProductosBindingSource;
        private Practica_De_Inventario_De_ProductosDataSetTableAdapters.MostrarProductosTableAdapter mostrarProductosTableAdapter;
    }
}