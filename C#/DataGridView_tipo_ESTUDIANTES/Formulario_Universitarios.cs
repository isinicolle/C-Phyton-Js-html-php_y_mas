using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_tipo_ESTUDIANTES
{
    public partial class Formulario_Universitarios : Form
    {
        public Formulario_Universitarios()
        {
            InitializeComponent();
         
        }

        Alumnos_universitario AU = new Alumnos_universitario();

        int i;

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            

            try
            {
                AU.Nombre = textBoxnOMBRE.Text;
                AU.NCuenta = Convert.ToInt32(textBoxCUENTA.Text);
                AU.N1 = Convert.ToInt32(textBoxN1.Text);
                AU.N2 = Convert.ToInt32(textBoxN2.Text);
                AU.N3 = Convert.ToInt32(textBoxN3.Text);


                if (AU.N1 == 0)
                {
                    MessageBox.Show("Ingrese una nota de 0 a 100", "Error", MessageBoxButtons.OK);
                    textBoxN1.Clear();
                    textBoxN1.Focus();
                }
                if (AU.N2 == 0)
                {
                    MessageBox.Show("Ingrese una nota de 0 a 100", "Error", MessageBoxButtons.OK);
                    textBoxN2.Clear();
                    textBoxN2.Focus();
                }
                if (AU.N3 == 0)
                {
                    MessageBox.Show("Ingrese una nota de 0 a 100", "Error", MessageBoxButtons.OK);
                    textBoxN3.Clear();
                    textBoxN3.Focus();
                }
                

                if(AU.N1 != 0 && AU.N2 != 0 && AU.N3 !=0 )
                {
                    labelpromedio.Text = AU.notaFinal(AU.N1, AU.N2, AU.N3).ToString("n2");
                    labelestadoAsignatura.Text = AU.estadoA();

                    TipoEstudiante.Text = AU.tipoEstudiante();
                }
                else
                {
                    MessageBox.Show("Ninguna nota puede estar incorrecta");
                }

               
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor no dejar campos vacios");
            }
        }

        private void Formulario_Universitarios_Load(object sender, EventArgs e)
        {
            labelestadoAsignatura.Text = " ";
            labelpromedio.Text = " ";
            TipoEstudiante.Text = " ";
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            i = dataGridView1.Rows.Add();

            dataGridView1.Rows[i].Cells[0].Value = textBoxCUENTA.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBoxnOMBRE.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBoxN1.Text;
            dataGridView1.Rows[i].Cells[3].Value = textBoxN3.Text;
            dataGridView1.Rows[i].Cells[4].Value = AU.Promedio.ToString("n2");
            dataGridView1.Rows[i].Cells[5].Value = AU.estadoA();

            labelestadoAsignatura.Text = " ";
            labelpromedio.Text = " ";
            TipoEstudiante.Text = " ";
            textBoxCUENTA.Clear();
            textBoxnOMBRE.Clear();
            textBoxN1.Clear();
            textBoxN2.Clear();
            textBoxN3.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs NumeroDeFila)
        {
            i = NumeroDeFila.RowIndex;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (i != -1)  //significa que hay una fila marcada y que es la que queremos eliminar
                {
                    dataGridView1.Rows.RemoveAt(i);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar fila"+ex, "Error");
            }
        }
    }
}
