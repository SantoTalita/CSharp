using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    class Conta
    {
        public double Saldo { get; set; }
        public Cliente titular;
        public int numero;

        public string agencia;

        public void Saca(double valorASacar)
        {
            if (valorASacar > 0 && valorASacar >= this.Saldo)
            {
                if (this.titular.EhMaiorDeIdade())
                {
                    this.Saldo -= valorASacar;
                }
                else {
                    if (this.Saldo >= 200)
                    {
                        this.Saldo -= 200;
                    }
                    
                }
                
            }
            
        }

        public void Deposita(double valorADepositar)
        {
            if(valorADepositar > 0)
            {
                this.Saldo += valorADepositar;
            }
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
