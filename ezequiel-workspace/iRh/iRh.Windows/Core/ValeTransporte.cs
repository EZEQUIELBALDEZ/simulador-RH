using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class ValeTransporte
    {
        public static double Calcula(double salario, double usoTransporteMes, double resultado  )
        {
            
            double valorValeTransporte = 0.0;

            const double valorPassagem = 4.20;

            valorValeTransporte = 0.06 * salario;

            resultado = valorPassagem * usoTransporteMes;



            return valorValeTransporte;
        }
    }
}
