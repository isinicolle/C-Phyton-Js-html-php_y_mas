using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DataGridView_tipo_ESTUDIANTES
{
    public class Clase_Persona
    {
        //atributos 

        private string nombre;
        private int n1;
        private int n2;
        private int n3;
        private int nCuenta;

        //propiedades usando encapsulamiento
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int N1
        {
            get
            {
                return n1;
            }
            set
            {
                if (value >= 1 && value <= 100)
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

        public int NCuenta { get => nCuenta; set => nCuenta = value; }

        public double notaFinal()
        {
            return 0;
        }

        public string estadoA()
        {
            return " ";
        }

        public virtual string tipoEstudiante()
        {
            return " ";
        }
    }
}
