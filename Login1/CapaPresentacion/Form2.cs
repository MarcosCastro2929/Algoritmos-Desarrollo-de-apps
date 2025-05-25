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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practica_De_Inventario_De_ProductosDataSet1EsteSi.ObtenerProductosActivos' Puede moverla o quitarla según sea necesario.
            this.obtenerProductosActivosTableAdapter.Fill(this.practica_De_Inventario_De_ProductosDataSet1EsteSi.ObtenerProductosActivos);
            // TODO: esta línea de código carga datos en la tabla 'practica_De_Inventario_De_ProductosDataSet1xddd.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.practica_De_Inventario_De_ProductosDataSet1xddd.Productos);
            // TODO: esta línea de código carga datos en la tabla 'practica_De_Inventario_De_Productos2DataCompletoxd.MostrarProductos' Puede moverla o quitarla según sea necesario.
            this.mostrarProductosTableAdapter2.Fill(this.practica_De_Inventario_De_Productos2DataCompletoxd.MostrarProductos);
            // TODO: esta línea de código carga datos en la tabla 'practica_De_Inventario_De_Productos2DataSet.MostrarProductos' Puede moverla o quitarla según sea necesario.
            this.mostrarProductosTableAdapter1.Fill(this.practica_De_Inventario_De_Productos2DataSet.MostrarProductos);
            this.mostrarProductosTableAdapter.Fill(this.practica_De_Inventario_De_ProductosDataSet.MostrarProductos);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
