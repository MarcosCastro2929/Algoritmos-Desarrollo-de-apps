using Capa_Negocios;
using CapaNegocio;
using CapaPresentacion;
using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Forms
{
    public partial class FrmFacturacion : Form
    {

        private readonly CN_Clientes negocioClientes = new CN_Clientes();
        private readonly CN_Articulos negocioProductos = new CN_Articulos();
        private readonly CN_Facturas negocioFacturas = new CN_Facturas();


        private DataTable detallesFactura = new DataTable();
        public FrmFacturacion()
        {
            InitializeComponent();
            InicializarTablaDetalles();
        }


        private void InicializarTablaDetalles()
        {
            detallesFactura = new DataTable();
            detallesFactura.Columns.Add("IdProducto", typeof(int));
            detallesFactura.Columns.Add("Producto", typeof(string));
            detallesFactura.Columns.Add("Cantidad", typeof(int));
            detallesFactura.Columns.Add("PrecioUnitario", typeof(decimal));
            detallesFactura.Columns.Add("Subtotal", typeof(decimal));

            dgvDetalles.DataSource = detallesFactura;
            ConfigurarColumnasDetalles();
        }

        private void ConfigurarColumnasDetalles()
        {
            dgvDetalles.Columns["IdProducto"].Visible = false;
            dgvDetalles.Columns["Producto"].HeaderText = "Producto";
            dgvDetalles.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvDetalles.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
            dgvDetalles.Columns["Subtotal"].HeaderText = "Subtotal";

            dgvDetalles.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";
            dgvDetalles.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
        }
        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarProductos();
            dtpFecha.Value = DateTime.Now;
        }

        private void CargarClientes()
        {
            cmbClientes.DataSource = negocioClientes.ObtenerClientesCombo();
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "Id_cliente";
            cmbClientes.SelectedIndex = -1;
        }

        private void CargarProductos()
        {
            cmbProductos.DataSource = negocioProductos.ObtenerArticulosCombo();
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "Id_articulo";
            cmbProductos.SelectedIndex = -1;
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedIndex != -1)
            {
                DataRowView Articulo = (DataRowView)cmbProductos.SelectedItem;
                txtPrecio.Text = Convert.ToDecimal(Articulo["Precio"]).ToString("C2");
                txtStockDisponible.Text = Articulo["Stock"].ToString();
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataRow row in detallesFactura.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }
            lblTotal.Text = total.ToString("C2");
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView Articulo = (DataRowView)cmbProductos.SelectedItem;
            int idProducto = Convert.ToInt32(Articulo["Id_articulo"]);
            string nombreProducto = Articulo["Nombre"].ToString();
            decimal precio = Convert.ToDecimal(Articulo["Precio"]);
            int stockDisponible = Convert.ToInt32(Articulo["Stock"]);

            if (cantidad > stockDisponible)
            {
                MessageBox.Show("No hay suficiente stock disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si el producto ya está en los detalles
            bool productoExistente = false;
            foreach (DataRow row in detallesFactura.Rows)
            {
                if (Convert.ToInt32(row["IdProducto"]) == idProducto)
                {
                    row["Cantidad"] = Convert.ToInt32(row["Cantidad"]) + cantidad;
                    row["Subtotal"] = Convert.ToInt32(row["Cantidad"]) * Convert.ToDecimal(row["PrecioUnitario"]);
                    productoExistente = true;
                    break;
                }
            }

            if (!productoExistente)
            {
                detallesFactura.Rows.Add(
                    idProducto,
                    nombreProducto,
                    cantidad,
                    precio,
                    cantidad * precio
                );
            }

            CalcularTotal();
            txtCantidad.Text = "1";
            cmbProductos.Focus();
        }

        


        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDetalles.SelectedRows)
                {
                    detallesFactura.Rows.RemoveAt(row.Index);
                }
                CalcularTotal();
            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {



            if (cmbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (detallesFactura.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la factura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);

            // Crear DataTable para enviar a la base de datos
            DataTable dtDetallesDB = new DataTable();
            dtDetallesDB.Columns.Add("IdProducto", typeof(int));
            dtDetallesDB.Columns.Add("Cantidad", typeof(int));
            dtDetallesDB.Columns.Add("PrecioUnitario", typeof(decimal));

            foreach (DataRow row in detallesFactura.Rows)
            {
                dtDetallesDB.Rows.Add(
                    row["IdProducto"],
                    row["Cantidad"],
                    row["PrecioUnitario"]
                );
            }

            string mensaje;
            int idFactura = negocioFacturas.CrearFactura(idCliente, dtDetallesDB, out mensaje);

            if (idFactura > 0)
            {
                MessageBox.Show($"Factura #{idFactura} generada correctamente\n{mensaje}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFactura();
            }
            else
            {
                MessageBox.Show(mensaje, "Perfecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            Factura nuevoFormulario = new Factura();
            nuevoFormulario.Show();
        }

        private void LimpiarFactura()
        {
            detallesFactura.Rows.Clear();
            cmbClientes.SelectedIndex = -1;
            cmbProductos.SelectedIndex = -1;
            txtCantidad.Text = "1";
            lblTotal.Text = "$0.00";
            dtpFecha.Value = DateTime.Now;
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            LimpiarFactura();
        }



        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            Factura nuevoFormulario = new Factura();
            nuevoFormulario.Show();
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
