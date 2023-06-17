namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSolicitouBeneficio = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtSolicitouBeneficio = new System.Windows.Forms.TextBox();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(46, 130);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(267, 29);
            this.txtSalario.TabIndex = 27;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Informe seu salário bruto:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(46, 246);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 30);
            this.btnCalcular.TabIndex = 25;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSolicitouBeneficio
            // 
            this.lblSolicitouBeneficio.AutoSize = true;
            this.lblSolicitouBeneficio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitouBeneficio.Location = new System.Drawing.Point(42, 26);
            this.lblSolicitouBeneficio.Name = "lblSolicitouBeneficio";
            this.lblSolicitouBeneficio.Size = new System.Drawing.Size(315, 21);
            this.lblSolicitouBeneficio.TabIndex = 24;
            this.lblSolicitouBeneficio.Text = "Quantas vezes você já solicitou o benefício? ";
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(46, 282);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(476, 136);
            this.panelResultado.TabIndex = 23;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(174, 29);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(104, 30);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // txtSolicitouBeneficio
            // 
            this.txtSolicitouBeneficio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicitouBeneficio.Location = new System.Drawing.Point(46, 59);
            this.txtSolicitouBeneficio.Name = "txtSolicitouBeneficio";
            this.txtSolicitouBeneficio.Size = new System.Drawing.Size(267, 29);
            this.txtSolicitouBeneficio.TabIndex = 32;
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.txtSolicitouBeneficio);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSolicitouBeneficio);
            this.Controls.Add(this.panelResultado);
            this.Name = "frmBeneficioSeguroDesemprego";
            this.Text = "frmBeneficioSeguroDesemprego";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSolicitouBeneficio;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtSolicitouBeneficio;
    }
}