using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        private string connectionString = "Server=DESKTOP-G79D1BT\\SQLEXPRESS;DataBase= Practica_De_Inventario_De_Productos;Integrated Security=true";

        public bool Login(string usuario, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("sp_Login", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
        }

   
        public string ObtenerRol(string usuario, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("sp_Login", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    return reader["Rol"].ToString();
                }

                return null;
            }
        }

        public int RegistrarUsuario(string usuario, string contraseña, string rol)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("sp_RegistrarUsuario", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);
                comando.Parameters.AddWithValue("@rol", rol);

                conexion.Open();
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

       
        public int RegistrarUsuarioConRol(string usuario, string contraseña, string rol)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("sp_RegistrarUsuario", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);
                comando.Parameters.AddWithValue("@rol", rol);

                conexion.Open();
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public bool ExisteUsuario(string usuario)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(
                    "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario",
                    conexion);

                comando.Parameters.AddWithValue("@usuario", usuario);

                conexion.Open();
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0;
            }
        }


        public string ObtenerRolDesdeBD(string usuario)
        {

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
               
           
                string rol = "";

                using (SqlCommand cmd = new SqlCommand("SELECT Rol FROM Usuarios WHERE Usuario = @usuario", conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    conexion.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        rol = result.ToString();
                    }

                    conexion.Close();
                }

                return rol;

            }
        }


    }
}
