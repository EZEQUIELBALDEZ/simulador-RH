using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{

    internal class Periculosidade
    {
        public static double Calcula(double salario)
        {
            double adicionalpericulosidade = 0.0;

            adicionalpericulosidade = salario * 0.3;

            return adicionalpericulosidade;
        }
    }
}
