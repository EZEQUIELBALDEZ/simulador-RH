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
            //    real adicional_ferias = 0.0


            //adicional_ferias = salario_bruto / 3


            //retorne mat.arredondar(adicional_ferias, 2)

            double AdicionalFerias = 0.0;

            AdicionalFerias = salario / 3;

          
            return (AdicionalFerias, 2);
        }
    }

}