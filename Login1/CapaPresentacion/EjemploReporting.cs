using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ejemplo_reporting : Form
    {
        public ejemplo_reporting()
        {
            InitializeComponent();
        }

        private void ejemplo_reporting_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practica_De_Inventario_De_ProductosDataSet.MostrarProductos' Puede moverla o quitarla según sea necesario.
            this.mostrarProductosTableAdapter.Fill(this.practica_De_Inventario_De_ProductosDataSet.MostrarProductos);
            // TODO: esta línea de código carga datos en la tabla 'practica_De_Inventario_De_ProductosDataSet.MostrarProductos' Puede moverla o quitarla según sea necesario.
            this.mostrarProductosTableAdapter.Fill(this.practica_De_Inventario_De_ProductosDataSet.MostrarProductos);

            this.reportViewer1.RefreshReport();
        }
    }
}
