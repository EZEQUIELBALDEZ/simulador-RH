using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class Irrf
    {
        const double Faixa01 = 1903.98;
        const double Faixa02 = 2826.65;
        const double Faixa03 = 3751.06;
        const double Faixa04 = 4664.68;
        public static double Calcula(double salario)
        {

            double valorIrrf = 0;
            if (salario <= Faixa01)
            {
                valorIrrf = 0.075 * salario;

            }
            else if (salario <= Faixa02)
            {
                var descontoFaixa1 = CalculaFaixa1(salario);
                valorIrrf = (salario - Faixa01) + descontoFaixa1;

            }
            else if (salario <= Faixa03)
            {
                var descontoFaixa1 = CalculaFaixa1(salario);
                var descontoFaixa2 = CalculaFaixa2(salario);
                valorIrrf = 12 / 100 * (salario - Faixa02) + descontoFaixa1 + descontoFaixa2;

            }
            else if (salario <= Faixa04)
            {
                var descontoFaixa1 = CalculaFaixa1(salario);
                var descontoFaixa2 = CalculaFaixa2(salario);
                var descontoFaixa3 = CalculaFaixa3(salario);

                valorIrrf = 0.14 * (salario - Faixa03)
                    + descontoFaixa1 + descontoFaixa2 + descontoFaixa3;
            }
            else
            {
                var descontoFaixa1 = CalculaFaixa1(salario);
                var descontoFaixa2 = CalculaFaixa2(salario);
                var descontoFaixa3 = CalculaFaixa3(salario);
                valorIrrf = 0.14 * (Faixa04 - Faixa03)
                    + descontoFaixa1 + descontoFaixa2 + descontoFaixa3;
            }
            return valorIrrf;
        }
        private static double CalculaFaixa1(double salario)
        {
            return (0.075 * Faixa01);
        }
        private static double CalculaFaixa2(double salario)
        {
            return 0.09 * (Faixa02 - Faixa01);
        }
        private static double CalculaFaixa3(double salario)
        {
            return 0.12 * (Faixa03 - Faixa02);
        }
    }
}
