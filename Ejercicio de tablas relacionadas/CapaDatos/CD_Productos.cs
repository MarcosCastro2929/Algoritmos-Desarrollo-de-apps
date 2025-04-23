using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexion.AbrirConexion()) 
            {
                using (SqlCommand cmd = new SqlCommand("MostrarProductos", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }

            
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos disponibles en la base de datos.");
            }

            return tabla;
        }


        public void Insertar(string nombre, string desc, string marca, double precio, int stock, int categoriaId, int estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProductos"; 
            comando.CommandType = CommandType.StoredProcedure;

            
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@categoriaId", categoriaId);
            comando.Parameters.AddWithValue("@estado", estado);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void Editar(string nombre, string desc, string marca, double precio, int stock, int categoriaId, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;

         
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@categoriaId", categoriaId);
            comando.Parameters.AddWithValue("@id", id);

          
            comando.ExecuteNonQuery();

        
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto"; 
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpro", id);
          
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }

    public class CD_Categorias
    {
       private CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCategorias()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT Id, Nombre FROM Categorias";
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
