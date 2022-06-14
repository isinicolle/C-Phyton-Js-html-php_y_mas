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
    public partial class Formulario_Profesores : Form
    {
        public Formulario_Profesores()
        {
            InitializeComponent();
        }

        int i;

        Clase_profesores cp = new Clase_profesores();

        private void Formulario_Profesores_Load(object sender, EventArgs e)
        {
            label7.Text = "Formulario de: " + cp.tipoPersona();
            label_edad.Text = "Edad: " + cp.Edad + "Años";
            textBox_nombre.Text = cp.Nombre;
            textBox_apellido.Text = cp.Apellido;
            textBox_genero.Text = cp.Genero;
            textBox_identidad.Text = cp.Id.ToString();

            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = dgb_docentes.Rows.Add();

            dgb_docentes.Rows[i].Cells[0].Value = textBox_identidad.Text;
            dgb_docentes.Rows[i].Cells[1].Value = textBox_genero.Text;
            dgb_docentes.Rows[i].Cells[2].Value = textBox_nombre.Text;
            dgb_docentes.Rows[i].Cells[3].Value = textBox_apellido.Text;
            dgb_docentes.Rows[i].Cells[4].Value = horastrabajadas.Value.ToString();
            dgb_docentes.Rows[i].Cells[5].Value = textBox_pxh.Text;
            dgb_docentes.Rows[i].Cells[6].Value = textBox_sueldo.Text;


            textBox_apellido.Clear();
            textBox_genero.Clear();
            textBox_identidad.Clear();
            textBox_nombre.Clear();
            textBox_pxh.Clear();
            textBox_sueldo.Clear();
            horastrabajadas.Value = 1;

            textBox_apellido.Enabled = true;
            textBox_genero.Enabled = true;
            textBox_identidad.Enabled = true;
            textBox_nombre.Enabled = true;
            textBox_pxh.Enabled = true;
            horastrabajadas.Enabled = true;


            button1.Visible = false;
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {

            textBox_apellido.Enabled = true;
            textBox_genero.Enabled = true;
            textBox_identidad.Enabled = true;
            textBox_nombre.Enabled = true;
            textBox_pxh.Enabled = true;
            horastrabajadas.Enabled = true;

            cp.ValidacionTextBox(textBox_apellido, textBox_genero, textBox_identidad, textBox_nombre);

            try
            {
                cp.Horas_trabajadas = Convert.ToInt32(horastrabajadas.Value.ToString());
                cp.Pago_hora = Convert.ToDouble(textBox_pxh.Text);

             

                 textBox_sueldo.Text = cp.calculo(cp.Horas_trabajadas, cp.Pago_hora).ToString("n2");


            }
            catch (Exception ex)
            {
                MessageBox.Show("No debe dejar ningun campo vacio" + ex);
            }



            button1.Visible = true;
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (i != -1)
                {
                    dgb_docentes.Rows.RemoveAt(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la fila " + ex, "Error", MessageBoxButtons.OK);
            }
        }

        private void dgb_docentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_apellido.Enabled = false;
            textBox_genero.Enabled = false;
            textBox_identidad.Enabled = false;
            textBox_nombre.Enabled = false;
            textBox_pxh.Enabled = false;
            horastrabajadas.Enabled = false;


            cp.ValidacionTextBox(textBox_apellido, textBox_genero, textBox_identidad, textBox_nombre);

                textBox_identidad.Text = dgb_docentes.CurrentRow.Cells[0].Value.ToString();
                textBox_genero.Text = dgb_docentes.CurrentRow.Cells[1].Value.ToString();
                textBox_nombre.Text = dgb_docentes.CurrentRow.Cells[2].Value.ToString();
                textBox_apellido.Text = dgb_docentes.CurrentRow.Cells[3].Value.ToString();
                horastrabajadas.Text = dgb_docentes.CurrentRow.Cells[4].Value.ToString();
                textBox_pxh.Text = dgb_docentes.CurrentRow.Cells[5].Value.ToString();
                textBox_sueldo.Text = dgb_docentes.CurrentRow.Cells[6].Value.ToString();
            
          
        
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox_apellido.Enabled = true;
            textBox_genero.Enabled = true;
            textBox_identidad.Enabled = true;
            textBox_nombre.Enabled = true;
            textBox_pxh.Enabled = true;
            horastrabajadas.Enabled = true;

            try {
             
                i = dgb_docentes.CurrentRow.Index;


                dgb_docentes.Rows[i].Cells[0].Value = textBox_identidad.Text;
                dgb_docentes.Rows[i].Cells[1].Value = textBox_genero.Text;
                dgb_docentes.Rows[i].Cells[2].Value = textBox_nombre.Text;
                dgb_docentes.Rows[i].Cells[3].Value = textBox_apellido.Text;
                dgb_docentes.Rows[i].Cells[4].Value = horastrabajadas.Value.ToString();
                dgb_docentes.Rows[i].Cells[5].Value = textBox_pxh.Text;
                dgb_docentes.Rows[i].Cells[6].Value = textBox_sueldo.Text;


                textBox_apellido.Clear();
                textBox_genero.Clear();
                textBox_identidad.Clear();
                textBox_nombre.Clear();
                textBox_pxh.Clear();
                textBox_sueldo.Clear();
                horastrabajadas.Value = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error..."+ex);
            }

        }
    }
}
