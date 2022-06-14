using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_hospital
{
    public class SuperClase_Persona
    {   
        private static string nombre, apellido , id , telefono;
        private static int edad;
        private static double subtotal;

        public string Telefono { get => telefono; set => telefono = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public  string Apellido { get => apellido; set => apellido = value; }
        public  string Id { get => id; set => id = value; }
        public  int Edad { get => edad; set => edad = value; }

        public virtual string tipoP() //metodo virtual
        {
            return " ";

        }

        public double Calculo()
        {
            return 0;
        }

        public double totalP()
        {
            return 0;
        }
    }
}
