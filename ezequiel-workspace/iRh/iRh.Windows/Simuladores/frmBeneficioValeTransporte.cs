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
    public partial class frmBeneficioValeTransporte : Form
    {

        public frmBeneficioValeTransporte()
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
                var salario = double.Parse(txtSalarioBruto.Text);
                var resultado = double.Parse(lblResultado.Text);
                var usoTransporteMes = double.Parse(txtusoTransporteMes.Text);

                var Beneficiovaletransporte = ValeTransporte.Calcula(salario, usoTransporteMes, resultado);

                

                

                lblResultado .Text = Beneficiovaletransporte.ToString("C");

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