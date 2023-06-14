using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Core
{
    internal class SeguroDesemprego
    {
        public static double Calcula(double salario, double SolicitouBeneficio)
        {
            const double SALARIOMINIMOATUAL = 1302.0;
            {
                double salarioAcumulado;

                if (SolicitouBeneficio > 0)
                {


                    MessageBox.Show("|Informe seu salário bruto: ");

                    if (SolicitouBeneficio == 1)
                    {
                        salarioAcumulado = salario * 18;


                        if (salario_acumulado / SALARIO_MINIMO_ATUAL >= 12)
                        {

                            MessageBox.Show("Você tem direito ao Seguro_Desemprego!");
                        }
                        else
                        {
                            MessageBox.Show("Você não tem direito ao Seguro_Desemprego!");
                        }

                    }

                    else if (quantidade_de_solicitacoes == 2)
                    {
                        salario_acumulado = salario_bruto * 12;

                        if (salario_acumulado / SALARIO_MINIMO_ATUAL >= 9)
                        {

                            MessageBox.Show("Você tem direito ao Seguro_Desemprego!");
                        }
                        else
                        {
                            MessageBox.Show("Você não tem direito ao Seguro_Desemprego!");
                        }


                    }
                    else if (quantidade_de_solicitacoes >= 3)
                    {

                        salario_acumulado = salario_bruto * 6
    
                    if (salario_acumulado / SALARIO_MINIMO_ATUAL >= 6)
                        {

                            MessageBox.Show("Você tem direito ao Seguro_Desemprego!");

                        }
                        else
                        {
                            MessageBox.Show("Você não tem direito ao Seguro_Desemprego!");
                        }

                    }

                }
                else
                {


                }






            }
                
        }
    }
}
