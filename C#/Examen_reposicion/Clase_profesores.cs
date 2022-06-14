using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_reposicion
{
    public class Clase_profesores : Superclase_personas //herencia
    {
        private static int horas_trabajadas;
        private static double pago_hora;

        public int Horas_trabajadas { get => horas_trabajadas; set => horas_trabajadas = value; }
        public double Pago_hora { get => pago_hora; set => pago_hora = value; }

        public new double calculo(int ht, double pxh) //polimorfismo
        {
            return (ht*pxh);
        }

        public override string tipoPersona()
        {
            return "Docente";
        }

    }
}
