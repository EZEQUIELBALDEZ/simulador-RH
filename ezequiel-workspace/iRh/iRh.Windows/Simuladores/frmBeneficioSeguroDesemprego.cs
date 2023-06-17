using iRh.Windows.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu salário base", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtSalario.Focus();
                return;

                double salarioAcumulado;

                var salario = double.Parse(txtSalario.Text);

                int quantidade_de_solicitacoes;


                const double salarioMinimoAtual = 1302.0;

                salarioAcumulado = salario * 18;


                if (salarioAcumulado / salarioMinimoAtual >= 12)
                {

                    MessageBox.Show("Você tem direito ao Seguro_Desemprego!");

                }
                else
                {
                    MessageBox.Show("Você não tem direito ao Seguro_Desemprego!");


                }




            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var solicitouBeneficio = double.Parse(txtSolicitouBeneficio.Text);
                var seguroDesemprego = SeguroDesemprego.Calcula(salario, solicitouBeneficio);

                lblResultado.Text = seguroDesemprego.ToString("C");

                lblResultado.Visible = true;
                panelResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor de salário válido, ex. 3500",
                                    "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

      
    }
}
