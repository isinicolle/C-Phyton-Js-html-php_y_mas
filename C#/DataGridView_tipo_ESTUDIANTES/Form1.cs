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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonUniversitarios_Click(object sender, EventArgs e)
        {

            Formulario_Universitarios fu  = new Formulario_Universitarios();
            fu.Show();

        }

        private void ButtonColegio_Click(object sender, EventArgs e)
        {
            Formulario_colegio fc = new Formulario_colegio();
            fc.Show();
        }
    }
}
