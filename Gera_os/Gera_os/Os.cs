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
    public partial class Os : Form
    {
        public List<Cliente> clientes_os;
         

    public Os(List<Cliente> clientes)
    {
        InitializeComponent();
        clientes_os = clientes;


    }

    private void Os_Load(object sender, EventArgs e)
    {
            foreach (var Cl in clientes_os)
            {
                cmbCliente.Items.Add(Cl.Nome);
                cmbCliente.Items.Add("teste");
            }
        }
}
}
