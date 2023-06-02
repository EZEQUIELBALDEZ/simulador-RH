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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblHorasTrabalhadasMes = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 29);
            this.textBox3.TabIndex = 34;
            // 
            // lblHorasTrabalhadasMes
            // 
            this.lblHorasTrabalhadasMes.AutoSize = true;
            this.lblHorasTrabalhadasMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadasMes.Location = new System.Drawing.Point(8, 81);
            this.lblHorasTrabalhadasMes.Name = "lblHorasTrabalhadasMes";
            this.lblHorasTrabalhadasMes.Size = new System.Drawing.Size(565, 21);
            this.lblHorasTrabalhadasMes.TabIndex = 29;
            this.lblHorasTrabalhadasMes.Text = "Agora informe a quantidade de vezes que você utiliza transporte público no mês";
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
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(267, 29);
            this.textBox4.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Informe seu salário bruto:";
            // 
            // frmBeneficioValeTransporte
            // 
            this.ClientSize = new System.Drawing.Size(588, 315);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblHorasTrabalhadasMes);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "Beneficio Vale Transporte";
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblHorasTrabalhadasMes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
    }
}