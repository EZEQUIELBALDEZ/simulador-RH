using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class ValeTransporte
    {
        public static double Calcula(double salario)
        {
            
            double valorValeTransporte = 0.0;

            valorValeTransporte = 0.06 * salario;

            return valorValeTransporte;
        }
    }
}
