//Isis Nicolle Zapata Florentino
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SuperClase_Persona scp = new SuperClase_Persona();
        Clase_pacientes cp = new Clase_pacientes();

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox_consulta.Visible = false;
        }

        private void radioButton_paciente_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_consulta.Visible = true;
        }

        private void radioButton_medico_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_consulta.Visible = false;
        }

        private void button_siguiente_Click(object sender, EventArgs e)
        {
            //le sume el precio de la consulta + 100 de gastos administrativos
            if (general.Checked)
            {
                scp.Subtotal = 600;
                cp.NombreM = "Dr. Mario Lopez";
                cp.EspecialidadM = "Medico General";
            }
                
            if (pediatria.Checked)
            {
                scp.Subtotal = 750;
                cp.NombreM = "Dr. Liliana Montes";
                cp.EspecialidadM = "Medico Pediatra";
            }

            if (geriatria.Checked)
            {
                scp.Subtotal = 900;
                cp.NombreM = "Dr.Juan Rivera";
                cp.EspecialidadM = "Medico Geriatra";
            }

            scp.Nombre = textBox_name.Text;
            scp.Id = textBox_id.Text;
            scp.Apellido = textBox_ape.Text;
            scp.Telefono = textBox_tel.Text;
            scp.Edad = DateTime.Now.Year - dateTimePicker1.Value.Year;

            Formulario_pago fp = new Formulario_pago();
            fp.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }
    }
}
