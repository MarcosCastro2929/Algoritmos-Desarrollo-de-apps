using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        CN_Categorias objetoCNCategorias = new CN_Categorias();
        private string idProducto = null;
        private bool Editar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.mostrarProductosTableAdapter1.Fill(this.practica_De_Inventario_De_ProductosDataSet.MostrarProductos);

            this.productosTableAdapter.Fill(this.practica_De_Inventario_De_Productos2estee.Productos);


            CargarCategorias();
            MostrarProdctos();
        }

        private void CargarCategorias()
        {
            try
            {
                DataTable categorias = objetoCNCategorias.MostrarCategorias();
                comboBoxCategorias.DataSource = categorias;
                comboBoxCategorias.DisplayMember = "Nombre"; 
                comboBoxCategorias.ValueMember = "Id";  
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las categorías: " + ex.Message);
            }
        }

        private void MostrarProdctos()
        {
            CN_Productos objeto = new CN_Productos();
            DataTable dt = objeto.MostrarProd();

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay productos disponibles para mostrar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string categoriaId = comboBoxCategorias.SelectedValue.ToString();

                if (!Editar)
                {
                    objetoCN.InsertarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, categoriaId);
                    MessageBox.Show("Producto agregado correctamente");
                }
                else
                {
                    objetoCN.EditarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, categoriaId, idProducto);
                    MessageBox.Show("Producto editado correctamente");
                    Editar = false;
                }

                MostrarProdctos();
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
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
                MessageBox.Show("Seleccione una fila, por favor.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarProd(idProducto);
                MessageBox.Show("Producto eliminado correctamente.");
                MostrarProdctos();
            }
            else
                MessageBox.Show("Seleccione una fila, por favor.");
        }

        private void limpiarForm()
        {
            txtNombre.Clear();
            txtDesc.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            comboBoxCategorias.SelectedIndex = 0;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nuevoFormulario = new Form2();
            nuevoFormulario.Show();
        }

        private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
