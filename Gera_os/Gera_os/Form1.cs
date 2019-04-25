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
    public partial class Form1 : Form
    {

       public List<Cliente> lista_form1; //crio uma lista aqui dentro
       

        public Form1(List<Cliente> lista_clientes)//lista passada do form cadastro clientes
        {

            lista_form1 = lista_clientes;//igualo a lista do construtor com a que eu criei aqui
            InitializeComponent();

        }

        private void cadastroDeClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cadastro_Clientes cadastro_Clientes = new Cadastro_Clientes();
            cadastro_Clientes.Show();
        }

        public void gerarOSToolStripMenuItem1_Click(object sender, EventArgs e)// menu que chama a tela de gerar o.s
        {
            
            Os os = new Os(lista_form1);//o que faco aqui? nao consigo passar nada
            os.Show();
        }

        
    }
}
