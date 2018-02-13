using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class CadastroDeConta : Form
    {
        private Form1 aplicacaoPrincipal;

        
        public CadastroDeConta(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Conta novaConta = new ContaCorrente();
            Cliente novoCliente = new Cliente(titularConta.Text);

            novaConta.titular = novoCliente;
            novaConta.numero = Convert.ToInt32(numeroConta.Text);
            this.aplicacaoPrincipal.AdicionaConta(novaConta);

        }
    }
}
