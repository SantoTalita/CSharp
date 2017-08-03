using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    public partial class Form1 : Form
    {
        private Conta umaConta;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente() { Nome = "Talita" };
            this.umaConta = new Conta() { Saldo = 2000, numero = 1, titular = cliente };
            MostraConta();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            this.umaConta.Deposita(valorDeposito);
            MostraConta();

        }

        private void MostraConta()
        {
            textoTitular.Text = umaConta.titular.Nome;
            textoSaldo.Text = Convert.ToString(umaConta.Saldo);
            textoNumero.Text = Convert.ToString(umaConta.numero);

        }
    }
}
