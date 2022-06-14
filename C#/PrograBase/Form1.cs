using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograBase
{
    public partial class Form1 : Form
    {
        clase_bd cbd = new clase_bd();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
           
            cbd.abrirConexion();

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            cbd.cerrarConexion();
        }

        private void btn_carreras_Click(object sender, EventArgs e)
        {
            Form_carrera fc =new Form_carrera();
            fc.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa de estudiantes usando un menusito jiji");
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_carrera carrera = new Form_carrera();
            carrera.Show();
        }
    }
}
