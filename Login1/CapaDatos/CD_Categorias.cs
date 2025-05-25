using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaDatos
{
    public class CD_Categorias
    {
        public DataTable MostrarCategorias()
        {
            throw new NotImplementedException();
        }

        public class CD_Categoria
        {

            private CD_Conexion conexion = new CD_Conexion();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            SqlDataReader leer;

            public DataTable Mostrar()
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_ObtenerCategorias";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;
            }



            public void Insertar(string nombre)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarCategoria";  // Asegúrate de que el procedimiento esté creado
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Nombre", nombre);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }


            public void Editar(int id, string nombre)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EditarCategoria"; // Asegúrate de que este procedimiento exista en tu BD
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@Nombre", nombre);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }


            public void Eliminar(int id)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarCategoria"; // Asegúrate de que este procedimiento exista en tu BD
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", id); // Usando 'Id' ya que en Categorias es el nombre del campo
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }








        }


    }
}
