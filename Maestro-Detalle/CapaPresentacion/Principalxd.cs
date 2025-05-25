using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Presentacion.Forms;

namespace CapaPresentacion
{
    public partial class Principalxd: Form
    {

        public Principalxd()
        {
            InitializeComponent();
        }

        public string RolUsuario { get; set; }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (RolUsuario == "Ventas")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;


            }
            if (RolUsuario == "Inventario")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;


            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (RolUsuario == "Ventas")
            {
                Clientes nuevoFormulario = new Clientes();
                nuevoFormulario.Show();

            }
            else if (RolUsuario == "Admin")
            {
                Clientes nuevoFormulario = new Clientes();
                nuevoFormulario.Show();

            }
            else
            {
                MessageBox.Show("Usted no puede acceder a este apartado");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RolUsuario == "Inventario")
            {
                Articulos nuevoFormulario = new Articulos();
                nuevoFormulario.Show();

            }
            else if (RolUsuario == "Admin")
            {
                Articulos nuevoFormulario = new Articulos();
                nuevoFormulario.Show();

            }
            else
            {
                MessageBox.Show("Usted no puede acceder a este apartado");
            }

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (RolUsuario == "Ventas")
            {
                FrmFacturacion nuevoFormulario = new FrmFacturacion();
                nuevoFormulario.Show();

            }
            else if (RolUsuario == "Admin")
            {
                FrmFacturacion nuevoFormulario = new FrmFacturacion();
                nuevoFormulario.Show();

            }
            else
            {
                MessageBox.Show("Usted no puede acceder a este apartado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Articulos nuevoFormulario = new Articulos();
            nuevoFormulario.Show();
        }

       

        
    }
}
