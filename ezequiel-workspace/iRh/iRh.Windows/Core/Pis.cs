using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class Pis
    {
        public static double Calcula(double salario, double mesesTrabalhados)
        {
            
            const double salarioMinimoAtual = 1302.0;

            double abonoPis = 0.0;

            abonoPis = salarioMinimoAtual * mesesTrabalhados / 12;

         
            return abonoPis;
        }

    }
}
