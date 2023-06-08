using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
 
     public static class HoraExtra
     {

        public static double Calcula(double salario, double horasTrabalhadasMes, double horaExtras, double taxaHoraExtra)
        {
            double valorHoraTrabalhada = salario / horasTrabalhadasMes;

            double adicionalHoraExtra = 0.0;

            double valorHoraExtra = valorHoraTrabalhada + taxaHoraExtra * valorHoraTrabalhada;


            adicionalHoraExtra = valorHoraExtra * horaExtras;

            double adicional_horas_extras = Calcula(salario, horasTrabalhadasMes, valorHoraTrabalhada, taxaHoraExtra);


            return adicionalHoraExtra;
        }

     }
}
