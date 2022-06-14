using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_reposicion
{
    public partial class Formulario_estudiantes : Form
    {
        public Formulario_estudiantes()
        {
            InitializeComponent();
        }

        Clase_alumnos ca = new Clase_alumnos();
        int i;

        private void Formulario_estudiantes_Load(object sender, EventArgs e)
        {
            label_estudiante.Text = ca.tipoPersona();
            label_edad.Text = "Edad: " +ca.Edad +"Años";
            textBox_nombre.Text = ca.Nombre;
            textBox_apellido.Text = ca.Apellido;
            textBox_genero.Text = ca.Genero;
            textBox_identidad.Text = ca.Id.ToString();

            button1.Visible = false;
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            i = dgv_estudiantes.Rows.Add();
        
            dgv_estudiantes.Rows[i].Cells[0].Value = textBox_identidad.Text;
            dgv_estudiantes.Rows[i].Cells[1].Value = textBox_genero.Text;
            dgv_estudiantes.Rows[i].Cells[2].Value = textBox_nombre.Text;
            dgv_estudiantes.Rows[i].Cells[3].Value = textBox_apellido.Text;
            dgv_estudiantes.Rows[i].Cells[4].Value = textBox_n1.Text;
            dgv_estudiantes.Rows[i].Cells[5].Value = textBox_n2.Text;
            dgv_estudiantes.Rows[i].Cells[6].Value = textBox_n3.Text;
            dgv_estudiantes.Rows[i].Cells[7].Value = textBox_prom.Text;

            textBox_apellido.Clear();
            textBox_genero.Clear();
            textBox_identidad.Clear();
            textBox_n1.Clear();
            textBox_n2.Clear();
            textBox_n3.Clear();
            textBox_nombre.Clear();
            textBox_prom.Clear();

            button1.Visible = false;
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                ca.N1 = Convert.ToInt32(textBox_n1.Text);
                ca.N2 = Convert.ToInt32(textBox_n2.Text);
                ca.N3 = Convert.ToInt32(textBox_n3.Text);

                if(string.IsNullOrEmpty(textBox_apellido.Text) || string.IsNullOrEmpty(textBox_genero.Text) || string.IsNullOrEmpty(textBox_identidad.Text) || string.IsNullOrEmpty(textBox_nombre.Text))
                {
                    MessageBox.Show("No dejar campos vacios");
                    textBox_nombre.Focus();
                }

                if (ca.N1 == 0)
                {
                    MessageBox.Show("Ingrese una nota de 0 a 100", "Error", MessageBoxButtons.OK);
                    textBox_n1.Clear();
                    textBox_n1.Focus();
                }
                if (ca.N2 == 0)
                {
                    MessageBox.Show("Ingrese una nota de 0 a 100", "Error", MessageBoxButtons.OK);
                    textBox_n2.Clear();
                    textBox_n2.Focus();
                }
                if (ca.N3 == 0)
                {
                    MessageBox.Show("Ingrese una nota de 0 a 100", "Error", MessageBoxButtons.OK);
                    textBox_n3.Clear();
                    textBox_n3.Focus();
                }



                if (ca.N1 != 0 && ca.N2 != 0 && ca.N3 != 0)
                {
                    textBox_prom.Text = ca.calculo(ca.N1, ca.N2, ca.N3).ToString("n2");
                  
                }
                else
                {
                    MessageBox.Show("Ninguna nota puede estar incorrecta");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No debe dejar ningun campo vacio"+ex);
            }

            button1.Visible = true;
        }

        private void dgv_estudiantes_CellContentClick(object sender, DataGridViewCellEventArgs NumeroDeFila)
        {
            i = NumeroDeFila.RowIndex;
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(i != -1)
                {
                    dgv_estudiantes.Rows.RemoveAt(i);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar la fila "+ex , "Error" , MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_identidad.Text = dgv_estudiantes.CurrentRow.Cells[0].Value.ToString();
            textBox_genero.Text = dgv_estudiantes.CurrentRow.Cells[1].Value.ToString();
            textBox_nombre.Text = dgv_estudiantes.CurrentRow.Cells[2].Value.ToString();
            textBox_apellido.Text = dgv_estudiantes.CurrentRow.Cells[3].Value.ToString();
            textBox_n1.Text = dgv_estudiantes.CurrentRow.Cells[4].Value.ToString();
            textBox_n2.Text = dgv_estudiantes.CurrentRow.Cells[5].Value.ToString();
            textBox_n3.Text = dgv_estudiantes.CurrentRow.Cells[6].Value.ToString();
            textBox_prom.Text = dgv_estudiantes.CurrentRow.Cells[7].Value.ToString();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = dgv_estudiantes.CurrentRow.Index;

            dgv_estudiantes.Rows[i].Cells[0].Value = textBox_identidad.Text;
            dgv_estudiantes.Rows[i].Cells[1].Value = textBox_genero.Text;
            dgv_estudiantes.Rows[i].Cells[2].Value = textBox_nombre.Text;
            dgv_estudiantes.Rows[i].Cells[3].Value = textBox_apellido.Text;
            dgv_estudiantes.Rows[i].Cells[4].Value = textBox_n1.Text;
            dgv_estudiantes.Rows[i].Cells[5].Value = textBox_n2.Text;
            dgv_estudiantes.Rows[i].Cells[6].Value = textBox_n3.Text;
            dgv_estudiantes.Rows[i].Cells[7].Value = textBox_prom.Text;


            textBox_apellido.Clear();
            textBox_genero.Clear();
            textBox_identidad.Clear();
            textBox_n1.Clear();
            textBox_n2.Clear();
            textBox_n3.Clear();
            textBox_nombre.Clear();
            textBox_prom.Clear();


        }
    }
}
