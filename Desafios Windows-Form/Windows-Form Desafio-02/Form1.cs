using System.Data;

namespace _02_Desafio_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtNombreEstudiante.Clear();
            cboArea.SelectedIndex = -1;
            cboCurso.SelectedIndex = -1;
            cboSeccion.SelectedIndex = -1;
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtPromedio.Clear();
            txtStatus.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEstudiante.Text;

            double nota1;
            double nota2;
            double nota3;
            double nota4;
            double Promedio;

            nota1 = int.Parse(txtNota1.Text);
            nota2 = int.Parse(txtNota2.Text);
            nota3 = int.Parse(txtNota3.Text);
            nota4 = int.Parse(txtNota4.Text);

            Promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            txtPromedio.Text = Promedio.ToString();


            if (Promedio >= 70)
            {
                
                txtStatus.Text = "El/La estudiante: " + nombre + " Aprovado!!";
            }
            else
            {
                
                txtStatus.Text = "El/La estudiante: " + nombre + " Reprovado";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void rdbFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
