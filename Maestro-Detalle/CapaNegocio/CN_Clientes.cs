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
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();

        public DataTable MostrarClientes()
        {
            return objetoCD.Mostrar();
        }

        public void InsertarCliente(string nombre, string direccion, string telefono, string correo, int estado)
        {
            objetoCD.Insertar(nombre, direccion, Convert.ToInt32(telefono), correo, estado);
        }

        public void EditarCliente(string nombre, string direccion, string telefono, string correo, string id)
        {
            objetoCD.Editar(nombre, direccion, Convert.ToInt32(telefono), correo, Convert.ToInt32(id));
        }

        public void EliminarCliente(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        public DataTable ObtenerClientesCombo()
        {
            return objetoCD.ObtenerClientesCombo();
        }
    }
}

