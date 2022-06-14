//Isis Nicolle Zapata Florentino 0801200108392

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Isis Zapata " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            groupBox_elegir.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Superclase_personas sp = new Superclase_personas();
            Formulario_estudiantes fe = new Formulario_estudiantes();
            Formulario_Profesores fp = new Formulario_Profesores();

            sp.ValidacionTextBox(textBox_apellido, textBox_genero, textBox_identidad, textBox_nombre, groupBox_elegir);

            sp.Edad = (DateTime.Today.Year - dateTimePicker_edad.Value.Year);
            sp.Genero = textBox_genero.Text;
            sp.Id = Convert.ToInt32(textBox_identidad.Text);
            sp.Nombre = textBox_nombre.Text;
            sp.Apellido = textBox_apellido.Text;

            
        
            if (radioButton_docente.Checked)
                fp.ShowDialog();

            if (radioButton_estudiante.Checked)
                fe.ShowDialog();

            
           
        }

        private void dateTimePicker_edad_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_edad.MaxDate = DateTime.Today;
        }
    }
}
