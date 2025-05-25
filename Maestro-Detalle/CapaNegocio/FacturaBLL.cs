using System;
using System.Data;
using Capa_Datos;

namespace Capa_Negocios
{
    public class FacturaBLL
    {
        private readonly FacturaDAL facturaDAL = new FacturaDAL();

        public DataSet ObtenerUltimaFactura()
        {
            try
            {
                DataSet ds = facturaDAL.ObtenerUltimaFactura();

                if (ds.Tables["Encabezado"].Rows.Count == 0)
                    throw new Exception("No se encontró la última factura");

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en negocio: " + ex.Message);
            }
        }
    }
}