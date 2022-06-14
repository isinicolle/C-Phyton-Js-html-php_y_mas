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
    public partial class Formulario_pago : Form
    {
        public Formulario_pago()
        {
            InitializeComponent();
        }
        Clase_pacientes cp = new Clase_pacientes();
        Formulario_factura factura = new Formulario_factura();

        private void boton_facturar_Click(object sender, EventArgs e)
        {
            if (atlantida.Checked)
            {
                cp.SeguroM = 0.60;
                cp.DescripcionSM = "Gracias al seguro medico usted solo pagara el 40%";
            }
                

            if (MAPFRE.Checked)
            {
                cp.SeguroM = 0.70;
                cp.DescripcionSM = "Gracias al seguro medico usted solo pagara el 30%";
            }

            if (PALIC.Checked)
            {
                cp.SeguroM = 0.80;
                cp.DescripcionSM = "Gracias al seguro medico usted solo pagara el 20%";
            }

            if (sinseguro.Checked)
            {
                cp.SeguroM = 0;
                cp.DescripcionSM = "Usted no tiene seguro medico tiene que pagar el 100%";
            }

            if (Tarjeta.Checked)
                cp.Calculo2(0.03);

            if (Efectivo.Checked)
                cp.Calculo2(0.00);

            
            factura.ShowDialog();
        }

        private void Formulario_pago_Load(object sender, EventArgs e)
        {
           
        }

      
    }
}
