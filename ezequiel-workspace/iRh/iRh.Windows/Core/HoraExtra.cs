using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
 
        public static class HoraExtra
        {
       
          
            public static double Calcula(double salario)
            {
            //    real valor_hora_trabalhada = salario_bruto / horas_trabalhadas_no_mes

            //real adicional_hora_extra = 0.0

            //real valor_hora_extra = valor_hora_trabalhada + taxa_da_hora_extra * valor_hora_trabalhada


            //adicional_hora_extra = valor_hora_extra * horas_extras


            //retorne mat.arredondar(adicional_hora_extra, 2)

                  double ValorHoraTrabalhada = salario / txtHorasTrabalhadasMes;
                  double adicionalHoraExtra = 0.0;
                  double ValorHoraExtra = ValorHoraTrabalhada + TaxaHoraExtra * ValorHoraTrabalhada;
                  adicionalHoraExtra = ValorHoraTrabalhada + horasextras;


                  return (adicionalHoraExtra, 2);
            }
        }
    
}
