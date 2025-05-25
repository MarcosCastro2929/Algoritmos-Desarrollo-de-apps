using System;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class RegistrarLog : Form
    {
        private CN_Usuarios cn_usuarios = new CN_Usuarios();



        public RegistrarLog()
        {
            InitializeComponent();
        }



        private void RegistrarLog_Load(object sender, EventArgs e)
        {
        }



        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar nuevoFormulario = new Registrar();
            nuevoFormulario.FormClosed += (s, args) => this.Close();
            nuevoFormulario.Show();
        }

        private void acceder_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text == "USUARIO" ? "" : txtUsuario.Text;
                string contraseña = txtContraseña.Text == "CONTRASEÑA" ? "" : txtContraseña.Text;

                if (string.IsNullOrEmpty(usuario))
                {
                    MessageBox.Show("Por favor ingrese un nombre de usuario");
                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Por favor ingrese una contraseña");
                    txtContraseña.Focus();
                    return;
                }

                if (cn_usuarios.Login(usuario, contraseña))
                {
                    string rol = cn_usuarios.ObtenerRol(usuario); 

                    if (rol == "Admin")
                    {
                        MessageBox.Show("Bienvenido Administrador");

                        Principalxd principal = new Principalxd();
                        principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                        principal.Show();
                        principal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else if (rol == "Ventas")
                    {
                        MessageBox.Show("Bienvenido Vendedor");

                        Principalxd principal = new Principalxd();
                        principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                        principal.Show();
                        principal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else if (rol == "Inventario")
                    {
                        MessageBox.Show("Bienvenido");

                        Principalxd principal = new Principalxd();
                        principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                        principal.Show();
                        principal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Rol no reconocido");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    txtContraseña.Text = "CONTRASEÑA";
                    txtContraseña.ForeColor = Color.DimGray;
                    txtContraseña.UseSystemPasswordChar = false;
                    txtContraseña.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Text = "USUARIO";
            txtUsuario.ForeColor = Color.DimGray;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.UseSystemPasswordChar = false;

            this.Show();
            txtUsuario.Focus();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}

