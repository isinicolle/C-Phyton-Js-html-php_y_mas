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

namespace PrograBase
{
    public partial class Form_carrera : Form
    {
        SqlCommand cmd;
        clase_bd cb = new clase_bd();

        public Form_carrera()
        {
            InitializeComponent();
        }

        

        private void Form_carrera_Load(object sender, EventArgs e)
        {
            cb.abrirConexion();
            cb.cargarDatosCarrera(dataGridView1);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == " " || textBox2.Text == " ")
                {
                    MessageBox.Show("No se puede insertar datos");
                }
                else
                {
                    cmd = new SqlCommand("Insert Into Carreras " +
                        " (CodCarrera , NombreCar) values " +
                        "(" + textBox1.Text + ",'" +textBox2.Text + "')" , cb.sc); // los tipos caracter apostrofes antes y despues
                   
                    string agregar = "Insert Into Carreras (CodCarrera , NombreCar) values (" + textBox1.Text + ",'" + textBox2.Text + "')";
                  
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Insertado");
                    
                    cb.cargarDatosCarrera(dataGridView1);
                   
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas..."+ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb.cerrarConexion();
            Close();
        }
    }
}
