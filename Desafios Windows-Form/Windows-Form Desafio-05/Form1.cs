using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Windows.Forms;

namespace _05_Desafio_GUi
{


    public partial class Form1 : Form
    {
        int Fila = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_AFP.Clear();
            txt_Cargo.Clear();
            txt_ISR.Clear();
            txt_NHijos.Clear();
            txt_Nombre.Clear();
            txt_Otro.Clear();
            txt_SFS.Clear();
            txt_Sueldo.Clear();
            txt_SueldoIncentivo.Clear();
            txt_Totaldesc.Clear();
            txt_Sueldoneto.Clear();
            txt_incentivo.Clear();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text;
            string cargo = txt_Cargo.Text;


            double afp = 0.0287;

            double sfs = 0.0304;


            double sueldoNeto;

            double sueldoAnual;



            double isr = 0;

            double totalDescuento;

            double sueldoBruto = double.Parse(txt_Sueldo.Text);




            afp = sueldoBruto * afp;

            sfs = sueldoBruto * sfs;




            sueldoNeto = sueldoBruto - sfs - afp;

            sueldoAnual = sueldoBruto * 12;

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


            int hijos = int.Parse(txt_NHijos.Text);


            if (hijos >= 1)
            {
                bonificaciones = hijos * 500;

                txt_SueldoIncentivo.Text = (sueldoBruto + bonificaciones).ToString();
            }
            else
            {
                txt_Sueldo.Text = "No aplica para incentivo";
            }


            txt_AFP.Text = afp.ToString();
            txt_ISR.Text = isr.ToString();
            txt_SFS.Text = sfs.ToString();
            txt_Totaldesc.Text = totalDescuento.ToString();
            txt_Sueldoneto.Text = sueldoNeto.ToString();
            txt_incentivo.Text = bonificaciones.ToString();


        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Guardado");
            Fila = dtgw_Info.Rows.Add();

            dtgw_Info.Rows[Fila].Cells[0].Value = txt_Nombre.Text;
            dtgw_Info.Rows[Fila].Cells[1].Value = txt_Sueldo.Text;
            dtgw_Info.Rows[Fila].Cells[2].Value = txt_incentivo.Text;
            dtgw_Info.Rows[Fila].Cells[3].Value = txt_SueldoIncentivo.Text;
            dtgw_Info.Rows[Fila].Cells[4].Value = txt_AFP.Text;
            dtgw_Info.Rows[Fila].Cells[5].Value = txt_SFS.Text;
            dtgw_Info.Rows[Fila].Cells[6].Value = txt_ISR.Text;
            dtgw_Info.Rows[Fila].Cells[7].Value = txt_Otro.Text;
            dtgw_Info.Rows[Fila].Cells[8].Value = txt_Totaldesc.Text;
            dtgw_Info.Rows[Fila].Cells[9].Value = txt_Sueldoneto.Text;




        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Crear el archivo de texto Reportes
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos .txt (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Guardar archivo como";
            saveFileDialog.FileName = "Reportes.txt";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {


                string filePath = saveFileDialog.FileName;
                MessageBox.Show("Archivo generado exitosamente en: " + filePath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);





                using (StreamWriter writer = new StreamWriter(filePath))
                {

                    for (int i = 0; i < dtgw_Info.Columns.Count; i++)
                    {
                        writer.Write(dtgw_Info.Columns[i].HeaderText);
                        if (i < dtgw_Info.Columns.Count - 1)
                            writer.Write("\t");
                    }
                    writer.WriteLine();


                    foreach (DataGridViewRow row in dtgw_Info.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dtgw_Info.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value?.ToString() ?? "");
                                if (i < dtgw_Info.Columns.Count - 1)
                                    writer.Write("\t");
                            }
                            writer.WriteLine();
                        }
                    }

                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dtgw_Info.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dtgw_Info.SelectedRows[0];
                selectedRow.ReadOnly = false;


                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    cell.ReadOnly = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }


        }

        private void txt_Cargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
