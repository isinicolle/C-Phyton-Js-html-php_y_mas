using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_hospital
{
    class Clase_pacientes :SuperClase_Persona
    {
        private static double pesoL, estaturaM, pesoI, descuento, seguroM , comi;
        private static string descripcionSM, nombreM , especialidadM;

        public double PesoL { get => pesoL; set => pesoL = value; }
        public  double EstaturaM { get => estaturaM; set => estaturaM = value; }
        public  double PesoI { get => pesoI; set => pesoI = value; }
        public  double Descuento { get => descuento; set => descuento = value; }
        public double SeguroM { get => seguroM; set => seguroM = value; }
        public double Comi { get => comi; set => comi = value; }
        public string DescripcionSM { get => descripcionSM; set => descripcionSM = value; }
        public  string NombreM { get => nombreM; set => nombreM = value; }
        public string EspecialidadM { get => especialidadM; set => especialidadM = value; }

        public double pesoIdeal()
        {
            return pesoI = (estaturaM - 1) * 220;
        }

        public override string tipoP() //metodo virtual
        {
            return "Paciente";
        }

        //sobrecarga
        public double Calculo2(int eda)
        {
            if (eda >= 60)
            {
                descuento = 0.25;
            }
            else
            if (eda <= 12)
            {
                descuento = 0.10;
            }
            else
                descuento = 0;

            return descuento;
        }

        public double Calculo2(double comision)
        {
            comi = comision;

            return comision * Subtotal;
        }

        public new double Calculo() //polimorfismo //impuesto
        {
            return 0.15; 
        }

        public new double totalP() //polimorfismo
        {
            return ((Subtotal) + (Calculo2(comi)) + (Subtotal*Calculo()) - (Subtotal*Descuento));
        }

        public double totalPC()
        {
            return totalP()-(totalP()*seguroM);
        }

    }
}
