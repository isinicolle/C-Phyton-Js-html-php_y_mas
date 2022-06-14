using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploLOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clase_conexion cc = new clase_conexion();

        private void btn_login_Click(object sender, EventArgs e)
        {
           // cc.abrirConexion();
            cc.login(tx_usuario.Text.Trim(), tx_contra.Text.Trim());
        }
    }
}
