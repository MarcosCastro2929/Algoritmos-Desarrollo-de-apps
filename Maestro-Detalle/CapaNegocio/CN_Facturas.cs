using System;
using System.Data;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CN_Facturas
    {
        private readonly CD_Facturas datosFacturas = new CD_Facturas();

        public int CrearFactura(int idCliente, DataTable detalles, out string mensaje)
        {
            if (idCliente <= 0)
            {
                mensaje = "Se debe seleccionar un cliente válido";
                return -1;
            }

            if (detalles == null || detalles.Rows.Count == 0)
            {
                mensaje = "La factura debe contener al menos un producto";
                return -1;
            }

            return datosFacturas.InsertarFactura(idCliente, detalles, out mensaje);
        }

        public DataTable ObtenerFactura(int idFactura)
        {
            if (idFactura <= 0)
                throw new ArgumentException("ID de factura no válido.");

            return datosFacturas.ObtenerFacturaPorId(idFactura);
        }

        public DataTable ObtenerDetallesFactura(int idFactura)
        {
            if (idFactura <= 0)
                throw new ArgumentException("ID de factura no válido.");

            return datosFacturas.ObtenerDetallesFactura(idFactura);
        }

        public DataTable ObtenerFacturasPorCliente(int idCliente)
        {
            if (idCliente <= 0)
                throw new ArgumentException("ID de cliente no válido.");

            return datosFacturas.ObtenerFacturasPorCliente(idCliente);
        }

        public DataTable ObtenerFacturasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
                throw new ArgumentException("La fecha de inicio no puede ser mayor a la fecha fin.");

            return datosFacturas.ObtenerFacturasPorFecha(fechaInicio, fechaFin);
        }

        public void AnularFactura(int idFactura, out string mensaje)
        {
            if (idFactura <= 0)
            {
                mensaje = "ID de factura no válido.";
                return;
            }

            datosFacturas.AnularFactura(idFactura, out mensaje);
        }
    }
}