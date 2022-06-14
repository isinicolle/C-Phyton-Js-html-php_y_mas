using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_reposicion
{
    public class Clase_alumnos : Superclase_personas //herencia
    {
        private static int n1;
        private static int n2;
        private static int n3;
       
        public int N1
        {
            get
            {
                return n1;
            }
            set
            {
                if(value>=1 && value<=100)
                {
                    n1 = value;
                }
                else
                {
                    n1 = 0;
                }
            }
        }

        public int N2
        {
            get
            {
                return n2;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    n2 = value;
                }
                else
                {
                    n2 = 0;
                }
            }
        }

        public int N3
        {
            get
            {
                return n3;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    n3 = value;
                }
                else
                {
                    n3 = 0;
                }
            }
        }

      
        public new double calculo(int n1, int n2, int n3) //polimorfismo
        {
            return (n1*0.25) + (n2*0.35) + (n3*0.40);
        }

        public override string tipoPersona()
        {
            return "Estudiante";
        }

    }

}





