using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class Ferias
    {
      
        public static double Calcula(double salario)
        {
            

            double AdicionalFerias = 0.0;

            AdicionalFerias = salario / 3;

          
            return AdicionalFerias;
        }
    }

}