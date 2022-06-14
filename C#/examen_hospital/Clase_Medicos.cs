using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_hospital
{
    public class Clase_Medicos: SuperClase_Persona
    {
        private static string especialidad ,yearServicio , UniEgresado;

        public static string Especialidad { get => especialidad; set => especialidad = value; }
        public static string YearServicio { get => yearServicio; set => yearServicio = value; }
        public static string UniEgresado1 { get => UniEgresado; set => UniEgresado = value; }

        public override string tipoP() //metodo virtual
        {
            return "Medico";
        }

    }
}
