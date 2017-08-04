using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaCorrente : Conta, ITributavel
    {
        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }
    }
}
