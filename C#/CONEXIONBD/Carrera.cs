using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONEXIONBD
{
    public partial class Carrera : Form
    {
        public Carrera()
        {
            InitializeComponent();
        }
        SqlCommand CMD;
        clase_bd c = new clase_bd();

        private void Carrera_Load(object sender, EventArgs e)
        {
            c.abrir();
            c.cargarDatosCarrera(dataGridView1);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1 =" " || textBox2 == " ")
                {
                    MessageBox.Show("No puede agregar datos en blanco");
                }
                else
                {
                    CMD = new SqlCommand("Insert Into Carreras"+
                        "CodCarrera, NombreCar) values" +
                        "(" + textBox1.Text + "")
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jiji" + ex);
            }


        }
    }
}
