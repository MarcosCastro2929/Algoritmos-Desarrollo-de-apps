namespace _01_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string cargo = txtCargo.Text;
            double afp = 0.0304;
            double sfs = 0.0287;
            double sueldoNeto;
            double sueldoAnual;
            double isr = 0;
            double totalDescuento;
            double sueldoBruto = double.Parse(txtSueldoBruto.Text);




            afp = sueldoBruto * afp;
            sfs = sueldoBruto * sfs;




            sueldoNeto = sueldoBruto - sfs - afp;
            sueldoAnual = sueldoNeto * 12;

            if (sueldoAnual >= 416220 && sueldoAnual < 624329)
            {
                isr = (sueldoAnual - 416220) * 0.15;
            }

            else if (sueldoAnual >= 624329 && sueldoAnual < 867123)
            {
                isr = 31216 + (sueldoAnual - 624329) * 0.20;
            }

            else if (sueldoAnual >= 867123)
            {
                isr = 79776 + (sueldoAnual - 867123) * 0.25;
            }


            totalDescuento = isr + afp + sfs;


            int bonificaciones = 0;


            int hijos = int.Parse(txtHijos.Text);


            if (hijos >= 1)
            {
                bonificaciones = hijos * 500;

                txtIncentivoHIjos.Text = bonificaciones.ToString();
            }
            else
            {
                txtIncentivoHIjos.Text = "No aplica para incentivo";
            }


            txtResultadoAfp.Text = afp.ToString();
            txtResultadoISr.Text = isr.ToString();
            txtResultadoSfs.Text = sfs.ToString();
            txtDescuentototal.Text = totalDescuento.ToString();
            txtNombreInfo.Text = nombre;
            txtResultadoCargo.Text = cargo;
            txtNeto.Text = sueldoNeto.ToString();
            txtAnual.Text = sueldoAnual.ToString();



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtAnual.Clear();
            txtCargo.Clear();
            txtDescuentototal.Clear();
            txtHijos.Clear();
            txtIncentivoHIjos.Clear();
            txtNeto.Clear();
            txtNombre.Clear();
            txtNombreInfo.Clear();
            txtOtrosDescuentos.Clear();
            txtResultadoAfp.Clear();
            txtResultadoCargo.Clear();
            txtResultadoISr.Clear();
          
            txtResultadoSfs.Clear();
            txtSueldoBruto.Clear();
           




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
