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
    public partial class Formulario_factura : Form
    {
        public Formulario_factura()
        {
            InitializeComponent();
        }
        Clase_pacientes cp = new Clase_pacientes();
        private void Formulario_factura_Load(object sender, EventArgs e)
        {
            textBox_ape.Text = cp.Apellido;
            textBox_edad.Text = cp.Edad.ToString();
            textBox_id.Text = cp.Id;
            textBox_tel.Text = cp.Telefono;
            textBox_comi.Text = cp.Comi.ToString("n2");
            textBox_desc.Text = cp.Calculo2(cp.Edad).ToString("n2");
            textBox_name.Text = cp.Nombre;
            textBox_sub.Text = cp.Subtotal.ToString("n2");
            textBox_isv.Text = cp.Calculo().ToString("n2");
            label15.Text = cp.DescripcionSM;
            textBox_total.Text = cp.totalP().ToString("n2");
            textBox_tpc.Text = cp.totalPC().ToString("n2");
            textBox_medico.Text = cp.NombreM;
            textBox_especialidad.Text = cp.EspecialidadM;
            

            label1.Text = "Fecha: " + DateTime.Now.ToShortDateString() + " Hora: " + DateTime.Now.ToShortTimeString();
        }

      
    }
}
