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
    public partial class Formulario_colegio : Form
    {
        public Formulario_colegio()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            Alumno_Colegio AU = new Alumno_Colegio();

            try
            {
                AU.Nombre = textBoxnOMBRE.Text;
                AU.NCuenta = Convert.ToInt32(textBoxCUENTA.Text);
                AU.N1 = Convert.ToInt32(textBoxN1.Text);
                AU.N2 = Convert.ToInt32(textBoxN2.Text);
                AU.N3 = Convert.ToInt32(textBoxN3.Text);
                AU.N4 = Convert.ToInt32(textBoxN4.Text);


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
                if (AU.N4 == 0)
                {
                    MessageBox.Show("Ingrese una nota de 0 a 100", "Error", MessageBoxButtons.OK);
                    textBoxN4.Clear();
                    textBoxN4.Focus();
                }
                else
                {
                    labelpromedio.Text = AU.notaFinal(AU.N1, AU.N2, AU.N3, AU.N4).ToString("n2");
                    labelestadoAsignatura.Text = AU.estadoA();

                    TipoEstudiante.Text = AU.tipoEstudiante();

                }
              
            }
            catch(Exception)
            {
                MessageBox.Show("Por favor no dejar campos vacios");
            }

            
        }

        private void Formulario_colegio_Load(object sender, EventArgs e)
        {
            labelestadoAsignatura.Text = " ";
            labelpromedio.Text = " ";
            TipoEstudiante.Text = " ";
        }
    }
}
