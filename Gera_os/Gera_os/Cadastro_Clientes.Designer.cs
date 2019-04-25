namespace Gera_os
{
    partial class Cadastro_Clientes
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
            this.lblNome_Cliente = new System.Windows.Forms.Label();
            this.lblEndereco_Cliente = new System.Windows.Forms.Label();
            this.lblTelefone_Cliente = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome_Cliente = new System.Windows.Forms.TextBox();
            this.txtEndereco_Cliente = new System.Windows.Forms.TextBox();
            this.txtTelefone_Cliente = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome_Cliente
            // 
            this.lblNome_Cliente.AutoSize = true;
            this.lblNome_Cliente.Location = new System.Drawing.Point(124, 63);
            this.lblNome_Cliente.Name = "lblNome_Cliente";
            this.lblNome_Cliente.Size = new System.Drawing.Size(85, 13);
            this.lblNome_Cliente.TabIndex = 0;
            this.lblNome_Cliente.Text = "Nome do Cliente";
            // 
            // lblEndereco_Cliente
            // 
            this.lblEndereco_Cliente.AutoSize = true;
            this.lblEndereco_Cliente.Location = new System.Drawing.Point(124, 104);
            this.lblEndereco_Cliente.Name = "lblEndereco_Cliente";
            this.lblEndereco_Cliente.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco_Cliente.TabIndex = 1;
            this.lblEndereco_Cliente.Text = "Endereco";
            // 
            // lblTelefone_Cliente
            // 
            this.lblTelefone_Cliente.AutoSize = true;
            this.lblTelefone_Cliente.Location = new System.Drawing.Point(124, 153);
            this.lblTelefone_Cliente.Name = "lblTelefone_Cliente";
            this.lblTelefone_Cliente.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone_Cliente.TabIndex = 2;
            this.lblTelefone_Cliente.Text = "Telefone";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(124, 207);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(34, 13);
            this.lblCnpj.TabIndex = 3;
            this.lblCnpj.Text = "CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastro de Cliente.";
            // 
            // txtNome_Cliente
            // 
            this.txtNome_Cliente.Location = new System.Drawing.Point(266, 63);
            this.txtNome_Cliente.Name = "txtNome_Cliente";
            this.txtNome_Cliente.Size = new System.Drawing.Size(351, 20);
            this.txtNome_Cliente.TabIndex = 5;
            // 
            // txtEndereco_Cliente
            // 
            this.txtEndereco_Cliente.Location = new System.Drawing.Point(266, 104);
            this.txtEndereco_Cliente.Name = "txtEndereco_Cliente";
            this.txtEndereco_Cliente.Size = new System.Drawing.Size(351, 20);
            this.txtEndereco_Cliente.TabIndex = 6;
            // 
            // txtTelefone_Cliente
            // 
            this.txtTelefone_Cliente.Location = new System.Drawing.Point(266, 153);
            this.txtTelefone_Cliente.Name = "txtTelefone_Cliente";
            this.txtTelefone_Cliente.Size = new System.Drawing.Size(153, 20);
            this.txtTelefone_Cliente.TabIndex = 7;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(266, 204);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(153, 20);
            this.txtCnpj.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(219, 278);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(180, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar Cliente";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Cadastro_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtTelefone_Cliente);
            this.Controls.Add(this.txtEndereco_Cliente);
            this.Controls.Add(this.txtNome_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblTelefone_Cliente);
            this.Controls.Add(this.lblEndereco_Cliente);
            this.Controls.Add(this.lblNome_Cliente);
            this.Name = "Cadastro_Clientes";
            this.Text = "Cadastro_Clientes";
            this.Load += new System.EventHandler(this.Cadastro_Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome_Cliente;
        private System.Windows.Forms.Label lblEndereco_Cliente;
        private System.Windows.Forms.Label lblTelefone_Cliente;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome_Cliente;
        private System.Windows.Forms.TextBox txtEndereco_Cliente;
        private System.Windows.Forms.TextBox txtTelefone_Cliente;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Button btnSalvar;
    }
}