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
using Capa_Presentacion.Forms;

namespace CapaPresentacion
{
    public partial class Clientes : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        private string idCliente = null;
        private bool Editar = false;

        public Clientes()
        {
            InitializeComponent();
        }

        

        public string RolUsuario { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

            

            MostrarClientes();

           
          
        }

        private void MostrarClientes() {

            CN_Clientes objeto = new CN_Clientes();
            DataTable Clientes = objeto.MostrarClientes();
            DataView vista = new DataView(Clientes);
            vista.RowFilter = "Estado = 1";
            dataGridView1.DataSource = vista;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarCliente(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, 1);
                    MessageBox.Show("Se insertó correctamente");
                    MostrarClientes();
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
                    objetoCN.EditarCliente(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, idCliente);
                    MessageBox.Show("se edito correctamente");
                    MostrarClientes();
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
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                idCliente = dataGridView1.CurrentRow.Cells["Id_cliente"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void limpiarForm() {
            txtDesc.Clear();
            txtMarca.Text = "";
            txtPrecio.Clear();
            txtNombre.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (RolUsuario == "Ventas")
            {

                MessageBox.Show("Usted no puede realizar esta acción");

            }
            else if (dataGridView1.SelectedRows.Count > 0)
            {
                idCliente = dataGridView1.CurrentRow.Cells["Id_cliente"].Value.ToString();
                objetoCN.EliminarCliente(idCliente);
                MessageBox.Show("Eliminado correctamente");
                MostrarClientes();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
