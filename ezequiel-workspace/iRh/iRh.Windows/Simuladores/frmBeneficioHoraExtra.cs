﻿using iRh.Windows.Core;
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
    public partial class frmBeneficioHoraExtra : Form
    {
        public frmBeneficioHoraExtra()
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
            }

            try
            {
                var salario = double.Parse(txtSalario.Text);
                var horas = double.Parse(txtHorasExtrasTrabalhadas.Text);
                var horasMeses = double.Parse(txtHorasTrabalhadasMes.Text);
                var taxaHoraTrabalhada = double.Parse(txtTaxaDeHora.Text);
                var beneficioHoraExtra = HoraExtra.Calcula(salario, horas, horasMeses, taxaHoraTrabalhada  );

                lblResultado.Text = beneficioHoraExtra.ToString("C");

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
