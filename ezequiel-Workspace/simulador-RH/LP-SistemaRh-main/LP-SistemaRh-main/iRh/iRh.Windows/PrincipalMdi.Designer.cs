namespace iRh.Windows
{
    partial class PrincipalMdi
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoInss = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoIrpf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBeneficioAdicionalNoturno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioDepositoFgts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioFerias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoraExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPericulosidade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeguroDesemprego = new System.Windows.Forms.ToolStripMenuItem();
            this.menuValeTransporte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.simuladoresToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.funcionáriosToolStripMenuItem.Text = "Cadastros";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cadastroToolStripMenuItem.Text = "Funcionarios";
            // 
            // simuladoresToolStripMenuItem
            // 
            this.simuladoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDescontoInss,
            this.menuDescontoIrpf,
            this.toolStripSeparator1,
            this.menuBeneficioAdicionalNoturno,
            this.menuBeneficioDepositoFgts,
            this.menuBeneficioFerias,
            this.menuHoraExtra,
            this.menuPericulosidade,
            this.menuPis,
            this.menuSeguroDesemprego,
            this.menuValeTransporte});
            this.simuladoresToolStripMenuItem.Name = "simuladoresToolStripMenuItem";
            this.simuladoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.simuladoresToolStripMenuItem.Text = "Simuladores";
            // 
            // menuDescontoInss
            // 
            this.menuDescontoInss.Name = "menuDescontoInss";
            this.menuDescontoInss.Size = new System.Drawing.Size(249, 22);
            this.menuDescontoInss.Text = "Desconto de INSS";
            this.menuDescontoInss.Click += new System.EventHandler(this.menuDescontoInss_Click);
            // 
            // menuDescontoIrpf
            // 
            this.menuDescontoIrpf.Name = "menuDescontoIrpf";
            this.menuDescontoIrpf.Size = new System.Drawing.Size(249, 22);
            this.menuDescontoIrpf.Text = "Desconto de IRPF";
            this.menuDescontoIrpf.Click += new System.EventHandler(this.menuDescontoIrpf_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // menuBeneficioAdicionalNoturno
            // 
            this.menuBeneficioAdicionalNoturno.Name = "menuBeneficioAdicionalNoturno";
            this.menuBeneficioAdicionalNoturno.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioAdicionalNoturno.Text = "Beneficio de Adicional Noturno";
            this.menuBeneficioAdicionalNoturno.Click += new System.EventHandler(this.menuBeneficioAdicionalNoturno_Click);
            // 
            // menuBeneficioDepositoFgts
            // 
            this.menuBeneficioDepositoFgts.Name = "menuBeneficioDepositoFgts";
            this.menuBeneficioDepositoFgts.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioDepositoFgts.Text = "Beneficio de Deposito FGTS";
            this.menuBeneficioDepositoFgts.Click += new System.EventHandler(this.menuBeneficioDepositoFgts_Click);
            // 
            // menuBeneficioFerias
            // 
            this.menuBeneficioFerias.Name = "menuBeneficioFerias";
            this.menuBeneficioFerias.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioFerias.Text = "Beneficio de Férias";
            this.menuBeneficioFerias.Click += new System.EventHandler(this.menuBeneficioFerias_Click);
            // 
            // menuHoraExtra
            // 
            this.menuHoraExtra.Name = "menuHoraExtra";
            this.menuHoraExtra.Size = new System.Drawing.Size(249, 22);
            this.menuHoraExtra.Text = "Beneficio de Hora Extra";
            this.menuHoraExtra.Click += new System.EventHandler(this.menuHoraExtra_Click);
            // 
            // menuPericulosidade
            // 
            this.menuPericulosidade.Name = "menuPericulosidade";
            this.menuPericulosidade.Size = new System.Drawing.Size(249, 22);
            this.menuPericulosidade.Text = "Beneficio de Periculosidade";
            this.menuPericulosidade.Click += new System.EventHandler(this.menuPericulosidade_Click);
            // 
            // menuPis
            // 
            this.menuPis.Name = "menuPis";
            this.menuPis.Size = new System.Drawing.Size(249, 22);
            this.menuPis.Text = "Beneficio de PIS";
            this.menuPis.Click += new System.EventHandler(this.menuPis_Click);
            // 
            // menuSeguroDesemprego
            // 
            this.menuSeguroDesemprego.Name = "menuSeguroDesemprego";
            this.menuSeguroDesemprego.Size = new System.Drawing.Size(249, 22);
            this.menuSeguroDesemprego.Text = "Beneficio de Seguro Desemprego";
            this.menuSeguroDesemprego.Click += new System.EventHandler(this.menuSeguroDesemprego_Click);
            // 
            // menuValeTransporte
            // 
            this.menuValeTransporte.Name = "menuValeTransporte";
            this.menuValeTransporte.Size = new System.Drawing.Size(249, 22);
            this.menuValeTransporte.Text = "Beneficio de Vale Transporte";
            this.menuValeTransporte.Click += new System.EventHandler(this.menuValeTransporte_Click);
            // 
            // PrincipalMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "PrincipalMdi";
            this.Text = "PrincipalMdi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalMdi_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simuladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoInss;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoIrpf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioAdicionalNoturno;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioDepositoFgts;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioFerias;
        private System.Windows.Forms.ToolStripMenuItem menuHoraExtra;
        private System.Windows.Forms.ToolStripMenuItem menuPericulosidade;
        private System.Windows.Forms.ToolStripMenuItem menuPis;
        private System.Windows.Forms.ToolStripMenuItem menuSeguroDesemprego;
        private System.Windows.Forms.ToolStripMenuItem menuValeTransporte;
    }
}