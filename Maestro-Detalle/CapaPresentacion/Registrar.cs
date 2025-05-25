using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Registrar : Form
    {
        private CN_Usuarios cn_usuarios = new CN_Usuarios();

        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            cbx_rol.Items.Clear();
            cbx_rol.Items.Add("Admin");
            cbx_rol.Items.Add("Ventas");
            cbx_rol.Items.Add("Inventario");
            cbx_rol.SelectedIndex = 0;
        }


        

        private void acceder_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void register_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarLog nuevoFormulario = new RegistrarLog();
            nuevoFormulario.FormClosed += (s, args) => this.Close();
            nuevoFormulario.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void register_lbl_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarLog nuevoFormulario = new RegistrarLog();
            nuevoFormulario.FormClosed += (s, args) => this.Close();
            nuevoFormulario.Show();
        }

        private void acceder_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text == "USUARIO" ? "" : txtUsuario.Text;
                string contraseña = txtContraseña.Text == "CONTRASEÑA" ? "" : txtContraseña.Text;
                string confirmacion = txtConfirmarContraseña.Text == "CONFIRMAR CONTRASEÑA" ? "" : txtConfirmarContraseña.Text;
                string rol = cbx_rol.SelectedItem?.ToString() ?? "";

                // Validación de campos
                if (string.IsNullOrEmpty(usuario))
                {
                    MessageBox.Show("Ingrese un nombre de usuario");
                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Ingrese una contraseña");
                    txtContraseña.Focus();
                    return;
                }

                if (contraseña.Length < 4)
                {
                    MessageBox.Show("La contraseña debe tener al menos 4 caracteres");
                    txtContraseña.Focus();
                    return;
                }

                if (contraseña != confirmacion)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    txtConfirmarContraseña.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(rol))
                {
                    MessageBox.Show("Seleccione un rol");
                    cbx_rol.Focus();
                    return;
                }

                int nuevoId = cn_usuarios.RegistrarUsuario(usuario, contraseña, rol);

                MessageBox.Show("Usuario registrado exitosamente");

                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
                txtConfirmarContraseña.Text = "CONFIRMAR CONTRASEÑA";
                txtConfirmarContraseña.ForeColor = Color.DimGray;
                txtConfirmarContraseña.UseSystemPasswordChar = false;

               
                this.Hide();

                if (rol == "Admin")
                {

                    Principalxd principal = new Principalxd();
                    principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                    principal.FormClosed += (s, args) => this.Close();
                    principal.Show();
                }
                if (rol == "Ventas")
                {

                    Principalxd principal = new Principalxd();
                    principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                    principal.FormClosed += (s, args) => this.Close();
                    principal.Show();
                }
                else
                {

                    Principalxd principal = new Principalxd();
                    principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                    principal.FormClosed += (s, args) => this.Close();
                    principal.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbx_rol_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
