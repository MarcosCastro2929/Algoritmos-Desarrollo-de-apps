using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd()
        {
            return objetoCD.Mostrar();
        }

        public void InsertarProd(string nombre, string desc, string marca, string precio, string stock, string categoriaId)
        {
            objetoCD.Insertar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(categoriaId));
        }

        public void EditarProd(string nombre, string desc, string marca, string precio, string stock, string categoriaId, string id)
        {
            objetoCD.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(categoriaId), Convert.ToInt32(id));
        }

        public void EliminarProd(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }

    public class CN_Categorias
    {
        private CD_Categorias objetoCD = new CD_Categorias();

        public DataTable MostrarCategorias()
        {
            return objetoCD.MostrarCategorias();
        }
    }
}

