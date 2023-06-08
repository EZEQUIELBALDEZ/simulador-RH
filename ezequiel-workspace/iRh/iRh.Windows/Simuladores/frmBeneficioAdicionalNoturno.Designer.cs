namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblReceberáPelasHorasnoTurnasTrabalhadas = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblHorasTrabalhadasMes = new System.Windows.Forms.Label();
            this.lblHorasNoturnasTrabalhadas = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadasMes = new System.Windows.Forms.TextBox();
            this.txtHorasNoturnasTrabalhadas = new System.Windows.Forms.TextBox();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelResultado.Controls.Add(this.lblReceberáPelasHorasnoTurnasTrabalhadas);
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(12, 291);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(696, 55);
            this.panelResultado.TabIndex = 4;
            this.panelResultado.Visible = false;
            // 
            // lblReceberáPelasHorasnoTurnasTrabalhadas
            // 
            this.lblReceberáPelasHorasnoTurnasTrabalhadas.AutoSize = true;
            this.lblReceberáPelasHorasnoTurnasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceberáPelasHorasnoTurnasTrabalhadas.Location = new System.Drawing.Point(13, 16);
            this.lblReceberáPelasHorasnoTurnasTrabalhadas.Name = "lblReceberáPelasHorasnoTurnasTrabalhadas";
            this.lblReceberáPelasHorasnoTurnasTrabalhadas.Size = new System.Drawing.Size(373, 21);
            this.lblReceberáPelasHorasnoTurnasTrabalhadas.TabIndex = 5;
            this.lblReceberáPelasHorasnoTurnasTrabalhadas.Text = "Você receberá pelas horas noturnas trabalhadas: R$\"";
            this.lblReceberáPelasHorasnoTurnasTrabalhadas.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(392, 16);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(86, 21);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 255);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 30);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(12, 59);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(267, 35);
            this.txtSalario.TabIndex = 6;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(8, 26);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(188, 21);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Informe seu salário bruto:";
            // 
            // lblHorasTrabalhadasMes
            // 
            this.lblHorasTrabalhadasMes.AutoSize = true;
            this.lblHorasTrabalhadasMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadasMes.Location = new System.Drawing.Point(8, 108);
            this.lblHorasTrabalhadasMes.Name = "lblHorasTrabalhadasMes";
            this.lblHorasTrabalhadasMes.Size = new System.Drawing.Size(280, 21);
            this.lblHorasTrabalhadasMes.TabIndex = 8;
            this.lblHorasTrabalhadasMes.Text = "Quantas horas você trabalhou no mês?";
            // 
            // lblHorasNoturnasTrabalhadas
            // 
            this.lblHorasNoturnasTrabalhadas.AutoSize = true;
            this.lblHorasNoturnasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnasTrabalhadas.Location = new System.Drawing.Point(8, 166);
            this.lblHorasNoturnasTrabalhadas.Name = "lblHorasNoturnasTrabalhadas";
            this.lblHorasNoturnasTrabalhadas.Size = new System.Drawing.Size(291, 21);
            this.lblHorasNoturnasTrabalhadas.TabIndex = 9;
            this.lblHorasNoturnasTrabalhadas.Text = "Quantas horas noturnas você trabalhou?";
            // 
            // txtHorasTrabalhadasMes
            // 
            this.txtHorasTrabalhadasMes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTrabalhadasMes.Location = new System.Drawing.Point(12, 132);
            this.txtHorasTrabalhadasMes.Name = "txtHorasTrabalhadasMes";
            this.txtHorasTrabalhadasMes.Size = new System.Drawing.Size(267, 35);
            this.txtHorasTrabalhadasMes.TabIndex = 10;
            // 
            // txtHorasNoturnasTrabalhadas
            // 
            this.txtHorasNoturnasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasNoturnasTrabalhadas.Location = new System.Drawing.Point(12, 190);
            this.txtHorasNoturnasTrabalhadas.Name = "txtHorasNoturnasTrabalhadas";
            this.txtHorasNoturnasTrabalhadas.Size = new System.Drawing.Size(267, 35);
            this.txtHorasNoturnasTrabalhadas.TabIndex = 11;
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.txtHorasNoturnasTrabalhadas);
            this.Controls.Add(this.txtHorasTrabalhadasMes);
            this.Controls.Add(this.lblHorasNoturnasTrabalhadas);
            this.Controls.Add(this.lblHorasTrabalhadasMes);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.panelResultado);
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "frmBeneficioAdicionalNoturno";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblHorasTrabalhadasMes;
        private System.Windows.Forms.Label lblHorasNoturnasTrabalhadas;
        private System.Windows.Forms.TextBox txtHorasTrabalhadasMes;
        private System.Windows.Forms.TextBox txtHorasNoturnasTrabalhadas;
        private System.Windows.Forms.Label lblReceberáPelasHorasnoTurnasTrabalhadas;
    }
}