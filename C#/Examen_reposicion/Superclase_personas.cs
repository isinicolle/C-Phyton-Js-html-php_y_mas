using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_reposicion
{
    public class Superclase_personas
    {
        private static string nombre, apellido, genero;
        private static int edad, id;
         

        //encapsulamiento
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Id { get => id; set => id = value; }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    edad = value;
                }
                else
                {
                    edad = 0;
                }
            }
        }

        //metodos

        //metodo virtual
        public virtual string tipoPersona()
        {
            return " ";
        }

        //Homonimia (sobrecarga)
        public double calculo(int ht , double pxh) 
        {
            return 0;
        }

        public double calculo(int n1, int n2 ,int n3)
        {
            return 0;
        }

        public void ValidacionTextBox(TextBox text, TextBox text2 , TextBox text3, TextBox text4, GroupBox gb)
        {
            if (string.IsNullOrEmpty(text.Text) || string.IsNullOrEmpty(text2.Text) || string.IsNullOrEmpty(text3.Text) || string.IsNullOrEmpty(text4.Text))
            {
                MessageBox.Show("Llenar todos los campos correctamente y no dejar campos vacios", "Error!");
            }
            else
            {
                gb.Visible = true;
            }
        }

        public void ValidacionTextBox(TextBox text, TextBox text2, TextBox text3, TextBox text4)
        {
            if (string.IsNullOrEmpty(text.Text) || string.IsNullOrEmpty(text2.Text) || string.IsNullOrEmpty(text3.Text) || string.IsNullOrEmpty(text4.Text))
            {
                MessageBox.Show("Llenar todos los campos correctamente y no dejar campos vacios", "Error!");
            }
           
        }


    }
}
