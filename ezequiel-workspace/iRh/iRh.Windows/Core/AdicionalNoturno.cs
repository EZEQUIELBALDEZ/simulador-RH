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

        public static double Calcula(double salario)
        {
           

            double txtHorasTrabalhadasMes;
            double txtHorasNoturnasTrabalhadas;


            double ValorHoraTrabalhada = salario/txtHorasTrabalhadasMes;
            double TaxaNoturna = 0.2;
            double AdicionalNoturno = 0.0;
            double HorasNoturnas = 60 * txtHorasNoturnasTrabalhadas / 52.5;

            lblResultado = taxanoturna * valorhoratrabalhada * txtHorasNoturnasTrabalhadas;

            return 0;
        }


    }
}
