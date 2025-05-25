using System;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace Capa_Datos
{
    public class CD_Facturas
    {
        private readonly CD_Conexion conexion = new CD_Conexion();
        
        public int InsertarFactura(int idCliente, DataTable detalles, out string mensaje)
        {
            int idFactura = -1;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarFactura", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                        SqlParameter paramDetalles = new SqlParameter("@Detalles", SqlDbType.Structured);
                        paramDetalles.TypeName = "DetalleFacturaType";
                        paramDetalles.Value = detalles;
                        cmd.Parameters.Add(paramDetalles);

                        SqlParameter paramMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                        paramMensaje.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(paramMensaje);

                        idFactura = Convert.ToInt32(cmd.ExecuteScalar());
                        mensaje = paramMensaje.Value.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Error al insertar factura: " + ex.Message;
            }

            return idFactura;
        }

        public DataTable ObtenerFacturaPorId(int idFactura)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerFacturaPorId", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdFactura", idFactura);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener factura: " + ex.Message);
            }
            return tabla;
        }

        public DataTable ObtenerDetallesFactura(int idFactura)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Detalle WHERE IdFactura = @IdFactura", conn))
                    {
                        cmd.Parameters.AddWithValue("@IdFactura", idFactura);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener detalles de factura: " + ex.Message);
            }
            return tabla;
        }

        public DataTable ObtenerFacturasPorCliente(int idCliente)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerFacturasPorCliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener facturas por cliente: " + ex.Message);
            }
            return tabla;
        }

        public DataTable ObtenerFacturasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerFacturasPorFecha", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener facturas por fecha: " + ex.Message);
            }
            return tabla;
        }

        public void AnularFactura(int idFactura, out string mensaje)
        {
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("AnularFactura", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdFactura", idFactura);

                        SqlParameter paramMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                        paramMensaje.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(paramMensaje);

                        cmd.ExecuteNonQuery();
                        mensaje = paramMensaje.Value.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Error al anular factura: " + ex.Message;
            }
        }
    }
}