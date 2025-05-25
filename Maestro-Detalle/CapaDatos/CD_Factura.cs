using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Factura
    {
        private CD_Conexion conexion = new CD_Conexion();
        private string connectionString = "Server=DESKTOP-FG1VE29;Database=SistemaFacturacion;Integrated Security=True;"; 

        public string LimpiarTablaReporte()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand("LimpiarTablaReporte", conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.ExecuteNonQuery();
                    return "Tabla limpiada correctamente.";
                }
                catch (Exception ex)
                {
                    return "Error al limpiar la tabla: " + ex.Message;
                }
            }
        }

        public DataTable MostrarFacturasClientesActivos()
        {
            DataTable tablaFacturas = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_MostrarFacturasClientesActivos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(tablaFacturas);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener facturas: " + ex.Message);
            }
            return tablaFacturas;
        }

        public string InsertarReporte(string nombreCliente, DateTime fechaFactura, string producto, int cantidad, decimal total)
        {
            string respuesta = "Reporte insertado correctamente.";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand("InsertarReportes", conn);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@nombre_cliente", nombreCliente);
                    comando.Parameters.AddWithValue("@fecha_factura", fechaFactura);
                    comando.Parameters.AddWithValue("@producto", producto);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@total", total);

                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    respuesta = "Error al insertar reporte: " + ex.Message;
                }
            }
            return respuesta;
        }

        public DataTable BuscarFacturasPorCliente(string nombre)
        {
            DataTable tablaFacturas = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_BuscarFacturasPorCliente", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(tablaFacturas);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la factura: " + ex.Message);
            }
            return tablaFacturas;
        }

        public string GuardarFactura(int? idCliente, DateTime fecha, int idArticulo, int cantidad, decimal total)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_GuardarFactura", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_cliente", (object)idCliente ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@id_articulo", idArticulo);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@total", total);

                    cmd.ExecuteNonQuery();
                    return "Compra realizada con éxito.";
                }
            }
            catch (SqlException ex)
            {
                return "Error al realizar la compra: " + ex.Message;
            }
        }


        public DataTable ObtenerClientes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ObtenerClientes", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }

            return dt;
        }

        public DataTable ObtenerProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                 using (SqlConnection conn = new SqlConnection(connectionString))
                 {
                    SqlCommand cmd = new SqlCommand("sp_ObtenerProductos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                 }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos: " + ex.Message);
            }
            return dt;
        }

        public string EliminarFactura(int idFactura)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_EliminarFactura2", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_factura", idFactura);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0 ? "Factura eliminada correctamente." : "No se encontró la factura.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar factura: " + ex.Message;
            }
        }
    }
}

