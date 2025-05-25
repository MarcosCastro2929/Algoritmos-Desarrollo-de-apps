using System;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios cd_usuarios = new CD_Usuarios();

        public bool Login(string usuario, string contraseña)
        {
            try
            {
                if (string.IsNullOrEmpty(usuario))
                    throw new ArgumentException("El usuario no puede estar vacío");

                if (string.IsNullOrEmpty(contraseña))
                    throw new ArgumentException("La contraseña no puede estar vacía");

                return cd_usuarios.Login(usuario, contraseña);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de negocio: " + ex.Message);
            }
        }

     
        public string ObtenerRol(string usuario, string contraseña)
        {
            try
            {
                return cd_usuarios.ObtenerRol(usuario, contraseña);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el rol: " + ex.Message);
            }
        }

        public int RegistrarUsuario(string usuario, string contraseña, string rol)
        {
            try
            {
                if (string.IsNullOrEmpty(usuario))
                    throw new ArgumentException("El usuario no puede estar vacío");
                if (string.IsNullOrEmpty(contraseña))
                    throw new ArgumentException("La contraseña no puede estar vacía");
                if (contraseña.Length < 4)
                    throw new ArgumentException("La contraseña debe tener al menos 4 caracteres");

                if (cd_usuarios.ExisteUsuario(usuario))
                    throw new ArgumentException("El usuario ya existe");

                return cd_usuarios.RegistrarUsuario(usuario, contraseña, rol);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de negocio: " + ex.Message);
            }
        }


        public string ObtenerRol(string usuario)
        {
            return cd_usuarios.ObtenerRolDesdeBD(usuario); 
        }



       
        public int RegistrarUsuarioConRol(string usuario, string contraseña, string rol)
        {
            try
            {
                if (string.IsNullOrEmpty(usuario))
                    throw new ArgumentException("El usuario no puede estar vacío");

                if (string.IsNullOrEmpty(contraseña))
                    throw new ArgumentException("La contraseña no puede estar vacía");

                if (string.IsNullOrEmpty(rol))
                    throw new ArgumentException("El rol no puede estar vacío");

                if (contraseña.Length < 4)
                    throw new ArgumentException("La contraseña debe tener al menos 4 caracteres");

                if (cd_usuarios.ExisteUsuario(usuario))
                    throw new ArgumentException("El usuario ya existe");

                return cd_usuarios.RegistrarUsuarioConRol(usuario, contraseña, rol);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar usuario con rol: " + ex.Message);
            }
        }
    }
}

