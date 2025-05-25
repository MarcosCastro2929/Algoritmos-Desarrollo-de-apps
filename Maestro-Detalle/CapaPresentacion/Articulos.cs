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
    public partial class Articulos: Form
    {
       

        CN_Articulos objetoCN = new CN_Articulos();
        private string  idArticulo = null;
        private bool Editar = false;

        public Articulos()
        {
            InitializeComponent();
        }


        private void Articulos_Load(object sender, EventArgs e)
        {

            MostrarArticulos();


        }

        

        private void MostrarArticulos()
        {

            CN_Articulos objeto = new CN_Articulos();
            DataTable Articulos = objeto.MostrarArticulos();
            DataView vista = new DataView(Articulos);
            vista.RowFilter = "Estado = 1";
            dataGridView1.DataSource = vista;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarArticulos(txtNombre.Text, txtPrecio.Text, txtStock.Text, 1);
                    MessageBox.Show("Se insertó correctamente");
                    MostrarArticulos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex.Message);
                }
            }




            if (Editar == true)
            {

                try
                {
                    objetoCN.EditarArticulos(txtNombre.Text, txtPrecio.Text, txtStock.Text, idArticulo);
                    MessageBox.Show("se edito correctamente");
                    MostrarArticulos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }


        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idArticulo = dataGridView1.CurrentRow.Cells["Id_articulo"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

       

        private void limpiarForm()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Text = "";
          
            
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idArticulo = dataGridView1.CurrentRow.Cells["Id_Articulo"].Value.ToString();
                objetoCN.EliminarArticulos(idArticulo);
                MessageBox.Show("Eliminado correctamente");
                MostrarArticulos();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
