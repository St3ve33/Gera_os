namespace Gera_os
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.gerarOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem1,
            this.pesquisaDeClientesToolStripMenuItem});
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cadastroDeClientesToolStripMenuItem.Text = " Clientes";
            // 
            // cadastroDeClientesToolStripMenuItem1
            // 
            this.cadastroDeClientesToolStripMenuItem1.Name = "cadastroDeClientesToolStripMenuItem1";
            this.cadastroDeClientesToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.cadastroDeClientesToolStripMenuItem1.Text = "Cadastro de Clientes";
            this.cadastroDeClientesToolStripMenuItem1.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem1_Click);
            // 
            // pesquisaDeClientesToolStripMenuItem
            // 
            this.pesquisaDeClientesToolStripMenuItem.Name = "pesquisaDeClientesToolStripMenuItem";
            this.pesquisaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pesquisaDeClientesToolStripMenuItem.Text = "Pesquisa de Clientes";
            // 
            // gerarOSToolStripMenuItem
            // 
            this.gerarOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarOSToolStripMenuItem1,
            this.pesquisarOSToolStripMenuItem});
            this.gerarOSToolStripMenuItem.Name = "gerarOSToolStripMenuItem";
            this.gerarOSToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.gerarOSToolStripMenuItem.Text = "Ordem de Servico";
            // 
            // gerarOSToolStripMenuItem1
            // 
            this.gerarOSToolStripMenuItem1.Name = "gerarOSToolStripMenuItem1";
            this.gerarOSToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.gerarOSToolStripMenuItem1.Text = "Gerar O.S.";
            this.gerarOSToolStripMenuItem1.Click += new System.EventHandler(this.gerarOSToolStripMenuItem1_Click);
            // 
            // pesquisarOSToolStripMenuItem
            // 
            this.pesquisarOSToolStripMenuItem.Name = "pesquisarOSToolStripMenuItem";
            this.pesquisarOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pesquisarOSToolStripMenuItem.Text = "Pesquisar O.S";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
         
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarOSToolStripMenuItem;
    }
}

