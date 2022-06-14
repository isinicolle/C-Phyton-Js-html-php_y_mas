using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_tipo_ESTUDIANTES
{
    public class Alumno_Colegio : Clase_Persona
    {
        private double promedio;
        private int n4;

        public int N4
        {
            get
            {
                return n4;
            }
            set
            {
               if(value>=1 && value<=100)
                {
                    n4 = value;
                }
               else
                {
                    n4 = 0;
                }
            }
        }

        public double Promedio
        {
            get
            {
                return promedio;
            }
            set
            {
                if (value > 1 && value <= 100)
                {
                    promedio = value;
                }
                else
                {
                    promedio = 0;
                }
            }
        }

        public double notaFinal(int n1, int n2, int n3, int n4)
        {
            promedio = (n1 + n2 + n3 + n4) / 4;

            return promedio;
        }

        public new string estadoA() //polimorfismo
        {
            string observacion;

            if (promedio >= 60)
            {
                observacion = "Aprobado";
            }
            else
            {
                observacion = "Reprobado";
            }

            return observacion;
        }

        public override string tipoEstudiante()
        {
            return "Alumno COLEGIAL";
        }
    }
}
