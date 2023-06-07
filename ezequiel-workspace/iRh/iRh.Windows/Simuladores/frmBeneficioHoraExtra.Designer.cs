namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHoraExtra
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
            this.txtHorasTrabalhadasMes = new System.Windows.Forms.TextBox();
            this.txtTaxaDeHora = new System.Windows.Forms.TextBox();
            this.txtHorasExtrasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lblTaxaDeHora = new System.Windows.Forms.Label();
            this.lblHorasExtrasTrabalhadas = new System.Windows.Forms.Label();
            this.lblHorasTrabalhadasMes = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHorasTrabalhadasMes
            // 
            this.txtHorasTrabalhadasMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTrabalhadasMes.Location = new System.Drawing.Point(424, 45);
            this.txtHorasTrabalhadasMes.Name = "txtHorasTrabalhadasMes";
            this.txtHorasTrabalhadasMes.Size = new System.Drawing.Size(267, 29);
            this.txtHorasTrabalhadasMes.TabIndex = 27;
            // 
            // txtTaxaDeHora
            // 
            this.txtTaxaDeHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaDeHora.Location = new System.Drawing.Point(424, 124);
            this.txtTaxaDeHora.Name = "txtTaxaDeHora";
            this.txtTaxaDeHora.Size = new System.Drawing.Size(267, 29);
            this.txtTaxaDeHora.TabIndex = 26;
            // 
            // txtHorasExtrasTrabalhadas
            // 
            this.txtHorasExtrasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasExtrasTrabalhadas.Location = new System.Drawing.Point(30, 124);
            this.txtHorasExtrasTrabalhadas.Name = "txtHorasExtrasTrabalhadas";
            this.txtHorasExtrasTrabalhadas.Size = new System.Drawing.Size(267, 29);
            this.txtHorasExtrasTrabalhadas.TabIndex = 25;
            // 
            // lblTaxaDeHora
            // 
            this.lblTaxaDeHora.AutoSize = true;
            this.lblTaxaDeHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxaDeHora.Location = new System.Drawing.Point(420, 100);
            this.lblTaxaDeHora.Name = "lblTaxaDeHora";
            this.lblTaxaDeHora.Size = new System.Drawing.Size(189, 21);
            this.lblTaxaDeHora.TabIndex = 24;
            this.lblTaxaDeHora.Text = "Qual a taxa da hora extra?";
            // 
            // lblHorasExtrasTrabalhadas
            // 
            this.lblHorasExtrasTrabalhadas.AutoSize = true;
            this.lblHorasExtrasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtrasTrabalhadas.Location = new System.Drawing.Point(27, 100);
            this.lblHorasExtrasTrabalhadas.Name = "lblHorasExtrasTrabalhadas";
            this.lblHorasExtrasTrabalhadas.Size = new System.Drawing.Size(270, 21);
            this.lblHorasExtrasTrabalhadas.TabIndex = 23;
            this.lblHorasExtrasTrabalhadas.Text = "Quantas horas Extras você trabalhou?";
            // 
            // lblHorasTrabalhadasMes
            // 
            this.lblHorasTrabalhadasMes.AutoSize = true;
            this.lblHorasTrabalhadasMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadasMes.Location = new System.Drawing.Point(420, 21);
            this.lblHorasTrabalhadasMes.Name = "lblHorasTrabalhadasMes";
            this.lblHorasTrabalhadasMes.Size = new System.Drawing.Size(280, 21);
            this.lblHorasTrabalhadasMes.TabIndex = 22;
            this.lblHorasTrabalhadasMes.Text = "Quantas horas você trabalhou no mês?";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(290, 193);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 30);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(31, 45);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(267, 29);
            this.txtSalario.TabIndex = 20;
     
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(27, 21);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(188, 21);
            this.lblSalario.TabIndex = 19;
            this.lblSalario.Text = "Informe seu salário bruto:";
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(138, 229);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(454, 113);
            this.panelResultado.TabIndex = 18;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(169, 41);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(104, 30);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHorasTrabalhadasMes);
            this.Controls.Add(this.txtTaxaDeHora);
            this.Controls.Add(this.txtHorasExtrasTrabalhadas);
            this.Controls.Add(this.lblTaxaDeHora);
            this.Controls.Add(this.lblHorasExtrasTrabalhadas);
            this.Controls.Add(this.lblHorasTrabalhadasMes);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.panelResultado);
            this.Name = "frmBeneficioHoraExtra";
            this.Text = "frmBeneficioHoraExtra";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHorasTrabalhadasMes;
        private System.Windows.Forms.TextBox txtTaxaDeHora;
        private System.Windows.Forms.TextBox txtHorasExtrasTrabalhadas;
        private System.Windows.Forms.Label lblTaxaDeHora;
        private System.Windows.Forms.Label lblHorasExtrasTrabalhadas;
        private System.Windows.Forms.Label lblHorasTrabalhadasMes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}