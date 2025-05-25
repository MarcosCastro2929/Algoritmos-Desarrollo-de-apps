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
    public partial class FormPrincipal: Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes nuevoFormulario = new Clientes();
            nuevoFormulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Articulos nuevoFormulario = new Articulos();
            nuevoFormulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmFacturacion nuevoFormulario = new FrmFacturacion();
            nuevoFormulario.Show();
        }
    }
}
