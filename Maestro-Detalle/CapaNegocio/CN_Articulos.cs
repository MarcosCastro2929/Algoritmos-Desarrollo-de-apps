 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Articulos
    {
        private CD_Articulo objetoCD = new CD_Articulo();

        public DataTable MostrarArticulos()
        {
            return objetoCD.Mostrar();
        }

        public void InsertarArticulos(string nombre, string precio, string stock, int estado)
        {
            objetoCD.Insertar(nombre, Convert.ToDouble(precio), Convert.ToInt32(stock), estado);
        }

        public void EditarArticulos(string nombre, string precio, string stock, string id)
        {
            objetoCD.Editar(nombre, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }

        public void EliminarArticulos(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        public DataTable ObtenerArticulosCombo()
        {
            return objetoCD.ObtenerArticulosCombo();
        }
    }
}

