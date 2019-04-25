using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gera_os
{
    public partial class Cadastro_Clientes : Form
    {
        public List<Cliente> lista_Clientes = new List<Cliente>();

        public Cadastro_Clientes()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)//na linha de baixo nao deu pra convert.toint16 pq?
        {
            lista_Clientes.Add(new Cliente() { Nome = txtNome_Cliente.Text, Cnpj = txtCnpj.Text, Telefone = txtTelefone_Cliente.Text, Endereco = txtEndereco_Cliente.Text });

            txtCnpj.Text = "";
            txtEndereco_Cliente.ResetText();
            txtNome_Cliente.ResetText();
            txtTelefone_Cliente.ResetText();


        }



        private void Cadastro_Clientes_Load(object sender, EventArgs e)
        {
            txtNome_Cliente.Focus();
            Os os = new Os(lista_Clientes);//construtor para passar de cadastro clientes para os
            Form1 form1 = new Form1(new List<Cliente>());
        }
    }
}
