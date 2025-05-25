using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class FacturaDAL
    {
        private readonly string cadenaConexion = "Server=DESKTOP-FG1VE29;Database=SistemaFacturacion;Integrated Security=True;";

        public DataSet ObtenerUltimaFactura()
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerUltimaFacturaCompleta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(ds);

                   
                        if (ds.Tables.Count > 0) ds.Tables[0].TableName = "Encabezado";
                        if (ds.Tables.Count > 1) ds.Tables[1].TableName = "Detalles";
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener última factura: " + ex.Message);
                    }
                }
            }

            return ds;
        }
    }
}