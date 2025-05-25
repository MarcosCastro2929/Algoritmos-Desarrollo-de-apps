using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
        private bool Editar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practica_De_Inventario_De_ProductosDataSet1xd.MostrarProductos' Puede moverla o quitarla según sea necesario.
            this.mostrarProductosTableAdapter.Fill(this.practica_De_Inventario_De_ProductosDataSet1xd.MostrarProductos);
            MostrarProdctos();
        }

        private void MostrarProdctos() {

            CN_Productos objeto = new CN_Productos();
            DataTable productos = objeto.MostrarProd();
            DataView vista = new DataView(productos);
            vista.RowFilter = "Estado = 1";
            dataGridView1.DataSource = vista;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, 1);
                    MessageBox.Show("Se insertó correctamente");
                    MostrarProdctos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex.Message);
                }
            }

      
       
        
            if (Editar == true) {

                try
                {
                    objetoCN.EditarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text,idProducto);
                    MessageBox.Show("se edito correctamente");
                    MostrarProdctos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex) {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void limpiarForm() {
            txtDesc.Clear();
            txtMarca.Text = "";
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarProd(idProducto);
                MessageBox.Show("Eliminado correctamente");
                    MostrarProdctos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nuevoFormulario = new Form2();
            nuevoFormulario.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
