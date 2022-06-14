using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_tipo_ESTUDIANTES
{
    public class Alumnos_universitario : Clase_Persona
    {

        private double promedio;

        public double Promedio
        {
            get
            {
                return promedio;
            }
            set
            {
                if(promedio>1 && promedio<=100)
                {
                    value = promedio;
                }
                else
                {
                    value = 0;
                }
            }
        }

        public double notaFinal(int n1 , int n2 , int n3)
        {
            promedio = (n1 * 0.25) + (n2 * 0.35) + (n3 * 0.40);

            return promedio;
        }

        public new string  estadoA() //polimorfismo
        {
            string observacion;
            
            if(promedio>=70)
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
            return "Alumno UNIVERSITARIO";
        }

    }
}
