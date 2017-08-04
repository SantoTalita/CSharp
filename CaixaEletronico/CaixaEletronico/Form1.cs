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
    public partial class Form1 : Form
    {
        private TotalizadorDeContas t;
        private ContaCorrente cc;
        private Conta c1;
        private Cliente cliente;



        private Conta[] contas = new Conta [2] ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.c1 = new Conta();
            this.cliente = new Cliente("Talita");
            this.c1.titular = cliente;
            this.c1.numero = 1;
            this.c1.Deposita(2500);

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            contas[1] = c1;
            this.t = new TotalizadorDeContas();
            this.cc = new ContaCorrente();
            this.cc.Deposita(2000);
            this.cliente = new Cliente("Ciro");
            this.cc.titular = cliente;
            t.Adiciona(cc);
            MessageBox.Show("Totalizador de contas: " + t.saldoTotal);
            contas[0] = cc;

            GerenciadorDeImposto g = new GerenciadorDeImposto();
            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.titular.Nome);
            }

            g.Adiciona(cc);
            MessageBox.Show("Tributos : " + Convert.ToString(g.Total));
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[index];
            textTitular.Text = contaSelecionada.titular.Nome;
            textSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textNumero.Text = Convert.ToString(contaSelecionada.numero);
        }
    }
}
