using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CONEXIONBD
{
    public class clase_bd
    {
        //alias 

        SqlDataAdapter da;
        DataTable dt;


        //crearemos una variable para establecer el nombre del servidor y nuestra base de datos a utilizar

        String _conexion = "DATA SOURCE = DESKTOP-0LCA87Q \\ SQLSERVER; " +
                            "Initial Catalog = Ejercicio;" +
                            "Integrated Security = true";

        //nombre de servidor [el mismo de sql]
        //donde sacare el catalogo de datos [Nombre de la base de datos]
        //seguridad de los datos


        //hacer instancia directamente

        public SqlConnection sc = new SqlConnection();
       
        //metodo constructor
        public clase_bd()
        {
            sc.ConnectionString = _conexion;
        }

        //metodos

        public void abrir()
        {
            try
            {
                sc.Open();
                MessageBox.Show("La conexion esta abierta jiji");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al abrir la base de datos"+ex+ MessageBoxIcon.Error);
            }//tryca
        }


        //cerrar

        public void cerrar()
        {
            sc.Close();
        }

        //metodo de carga data grid
        public void cargarDatosCarrera(DataGridView DGV)
        {
            try
            {
                da = new SqlDataAdapter("Select * From Carreras", _conexion);
                dt = new DataTable();
                da.Fill(dt);
                DGV.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! se encontro que: "+ex.ToString());
            }
        }

    }//return 0;
}
