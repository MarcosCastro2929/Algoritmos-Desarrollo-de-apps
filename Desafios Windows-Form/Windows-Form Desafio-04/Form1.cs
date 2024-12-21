using System.Configuration;
using System.Windows.Forms;

namespace _04_Desafio_GUi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double total = 0;
            double precioUnitario = 0;
            double precio = 0;


            if (cboNombre.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un producto");
                return;
            }


            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad ");
                return;
            }


            if (cboNombre.SelectedIndex == 0)
            {
                precioUnitario = 75;
            }
            else if (cboNombre.SelectedIndex == 1)
            {
                precioUnitario = 50;
            }
            else if (cboNombre.SelectedIndex == 2)
            {
                precioUnitario = 25;
            }


            precio = precioUnitario * cantidad;
            txtPrecio.Text = precio.ToString();


            foreach (DataGridViewRow fila in dtgwFactura.Rows)
            {
                if (!fila.IsNewRow && fila.Cells["Subtotal"].Value != null)
                {
                    double subtotal;
                    if (double.TryParse(fila.Cells["Subtotal"].Value.ToString(), out subtotal))
                    {
                        total += subtotal;
                    }
                }
            }


            if (dtgwFactura.Rows.Count > 0)
            {
                dtgwFactura.Rows[0].Cells["Total"].Value = total;
            }

            lbl_totalDeTotales.Text = total.ToString();

            // Agregar una nueva fila al DRGW
            int Fila = dtgwFactura.Rows.Add();
            dtgwFactura.Rows[Fila].Cells[0].Value = cboNombre.Text;
            dtgwFactura.Rows[Fila].Cells[1].Value = cantidad.ToString();
            dtgwFactura.Rows[Fila].Cells[2].Value = precioUnitario.ToString();
            dtgwFactura.Rows[Fila].Cells[3].Value = precio.ToString();
            dtgwFactura.Rows[Fila].Cells[4].Value = total.ToString();

            lbl_Articulos.Text = cboNombre.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            txtCantidad.Clear();
            cboNombre.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtgwFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
