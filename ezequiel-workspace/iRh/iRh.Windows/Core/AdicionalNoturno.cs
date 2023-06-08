using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class AdicionalNoturno
    {

        public static double Calcula(double salario, double horasNoturnasTrabalhadas, double horasTrabalhadas)
        {
            


            double valorHoraTrabalhada = salario / horasTrabalhadas;
            double taxaNoturna = 0.2;
            double adicionalNoturno = 0.0;
            double horasNoturnas = 60 * horasNoturnasTrabalhadas / 52.5;

            adicionalNoturno = taxaNoturna  * valorHoraTrabalhada * horasNoturnas;

            return adicionalNoturno;
        }


    }
}
