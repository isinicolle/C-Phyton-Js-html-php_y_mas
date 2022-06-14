using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Permissions;

namespace EjemploLOGIN
{
    public class clase_conexion
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0LCA87Q\\SQLSERVER;Initial Catalog=Ejemploxdxd;Integrated Security=True") ;
        

        //abrir y cerrar conexion
        public void abrirConexion()
        {
            try
            {
                con.Open();
                MessageBox.Show("La conexion esta abierta");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas..."+ex);
            }
        }

        public void cerrarConexion()
        {
            con.Close();
            MessageBox.Show("La conexions e ha cerrado");

        }

        public void login(string usuario ,string clave)
        {

           // try
           // {
                abrirConexion();
                string clausula = "SELECT nombre_usuario From usuarios Where nombre_usuario='" + usuario + "' AND contrasena='" + clave + "'";
                SqlDataAdapter sda = new SqlDataAdapter(clausula, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Bienvenido");
                    
                }

               // cerrarConexion();

           // }
          //  catch (Exception ex)
           // {
               // MessageBox.Show("El usuario no existe"+ex);
          //  }

             
               
        }



    }
}
