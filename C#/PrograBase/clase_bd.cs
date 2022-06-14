using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrograBase
{
    public class clase_bd
    {
        //Atributos

        //alias para las clases
        SqlDataAdapter da;
        DataTable dt;


        string _conexion = "Data Source = DESKTOP-0LCA87Q \\SQLSERVER; " +
            "Initial Catalog = Ejercicio;" +
            "Integrated Security = True ";

      
        //Instancia
        public SqlConnection sc = new SqlConnection();

        //Metodo  Constructor
        public clase_bd()
        {
            sc.ConnectionString = _conexion;
        }

        //metodos
        public void abrirConexion()
        {
            try
            {
                sc.Open();
                MessageBox.Show("Sesion Abierta");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas..." + ex);
            }
        }


        public void cerrarConexion()
        {
            MessageBox.Show("Cerra2");
            sc.Close();
        }
        //metodos para abrir y cerrar la base de datos


        //metodos de la siguiente clase de profgramacion

        //metodo cargar al data grie
        public void cargarDatosCarrera(DataGridView dgv)
        {
            try
            {

                da = new SqlDataAdapter("Select * feom Carreras",_conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas..."+ex.ToString());
            }
        }

        //public void cargarDatosCurso

        //return 0;
    }
}
