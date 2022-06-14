using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONEXIONBD
{
    public partial class Form1 : Form
    {
        clase_bd BD = new clase_bd();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conectasr_Click(object sender, EventArgs e)
        {
            

            BD.abrir();
        }

        private void btn_descoenctar_Click(object sender, EventArgs e)
        {
            BD.cerrar();
        }

        private void btn_carrera_Click(object sender, EventArgs e)
        {
            Carrera c = new Carrera();
        }
    }
}
