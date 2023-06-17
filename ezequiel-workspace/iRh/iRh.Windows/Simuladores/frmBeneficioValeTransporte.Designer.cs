namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioValeTransporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtusoTransporteMes = new System.Windows.Forms.TextBox();
            this.lblusoTransporteNoMes = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.lblResulto = new System.Windows.Forms.Label();
            this.lblDescontadoCasoOpteValeTransporte = new System.Windows.Forms.Label();
            this.lblVoceGastaria = new System.Windows.Forms.Label();
            this.lblReusltadoDesconto = new System.Windows.Forms.Label();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtusoTransporteMes
            // 
            this.txtusoTransporteMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusoTransporteMes.Location = new System.Drawing.Point(12, 105);
            this.txtusoTransporteMes.Name = "txtusoTransporteMes";
            this.txtusoTransporteMes.Size = new System.Drawing.Size(267, 29);
            this.txtusoTransporteMes.TabIndex = 34;
            // 
            // lblusoTransporteNoMes
            // 
            this.lblusoTransporteNoMes.AutoSize = true;
            this.lblusoTransporteNoMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusoTransporteNoMes.Location = new System.Drawing.Point(8, 81);
            this.lblusoTransporteNoMes.Name = "lblusoTransporteNoMes";
            this.lblusoTransporteNoMes.Size = new System.Drawing.Size(565, 21);
            this.lblusoTransporteNoMes.TabIndex = 29;
            this.lblusoTransporteNoMes.Text = "Agora informe a quantidade de vezes que você utiliza transporte público no mês";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 162);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 30);
            this.btnCalcular.TabIndex = 28;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.Location = new System.Drawing.Point(12, 37);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(267, 29);
            this.txtSalarioBruto.TabIndex = 36;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(8, 13);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(188, 21);
            this.lblSalarioBruto.TabIndex = 35;
            this.lblSalarioBruto.Text = "Informe seu salário bruto:";
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelResult.Controls.Add(this.lblReusltadoDesconto);
            this.panelResult.Controls.Add(this.lblResulto);
            this.panelResult.Controls.Add(this.lblDescontadoCasoOpteValeTransporte);
            this.panelResult.Controls.Add(this.lblVoceGastaria);
            this.panelResult.Location = new System.Drawing.Point(12, 216);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(614, 127);
            this.panelResult.TabIndex = 37;
            // 
            // lblResulto
            // 
            this.lblResulto.AutoSize = true;
            this.lblResulto.Location = new System.Drawing.Point(162, 30);
            this.lblResulto.Name = "lblResulto";
            this.lblResulto.Size = new System.Drawing.Size(65, 13);
            this.lblResulto.TabIndex = 38;
            this.lblResulto.Text = "lblResultado";
            // 
            // lblDescontadoCasoOpteValeTransporte
            // 
            this.lblDescontadoCasoOpteValeTransporte.AutoSize = true;
            this.lblDescontadoCasoOpteValeTransporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontadoCasoOpteValeTransporte.Location = new System.Drawing.Point(28, 83);
            this.lblDescontadoCasoOpteValeTransporte.Name = "lblDescontadoCasoOpteValeTransporte";
            this.lblDescontadoCasoOpteValeTransporte.Size = new System.Drawing.Size(368, 21);
            this.lblDescontadoCasoOpteValeTransporte.TabIndex = 37;
            this.lblDescontadoCasoOpteValeTransporte.Text = "Será descontado, caso opte pelo vale-transporte: R$";
            // 
            // lblVoceGastaria
            // 
            this.lblVoceGastaria.AutoSize = true;
            this.lblVoceGastaria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoceGastaria.Location = new System.Drawing.Point(28, 24);
            this.lblVoceGastaria.Name = "lblVoceGastaria";
            this.lblVoceGastaria.Size = new System.Drawing.Size(128, 21);
            this.lblVoceGastaria.TabIndex = 36;
            this.lblVoceGastaria.Text = "Você gastaria: R$";
            // 
            // lblReusltadoDesconto
            // 
            this.lblReusltadoDesconto.AutoSize = true;
            this.lblReusltadoDesconto.Location = new System.Drawing.Point(411, 91);
            this.lblReusltadoDesconto.Name = "lblReusltadoDesconto";
            this.lblReusltadoDesconto.Size = new System.Drawing.Size(65, 13);
            this.lblReusltadoDesconto.TabIndex = 39;
            this.lblReusltadoDesconto.Text = "lblResultado";
            // 
            // frmBeneficioValeTransporte
            // 
            this.ClientSize = new System.Drawing.Size(715, 360);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.txtusoTransporteMes);
            this.Controls.Add(this.lblusoTransporteNoMes);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "Beneficio Vale Transporte";
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtTransportePublico;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTransportePublico;
        private System.Windows.Forms.Button btnCalcularValeTransporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusoTransporteMes;
        private System.Windows.Forms.Label lblusoTransporteNoMes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label lblDescontadoCasoOpteValeTransporte;
        private System.Windows.Forms.Label lblVoceGastaria;
        private System.Windows.Forms.Label lblResulto;
        private System.Windows.Forms.Label lblReusltadoDesconto;
    }
}