using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    public class Produto
    {
        public int Id { get; private set; }
        public String Nome { get; private set; }
        public double Preco { get; private set; }

        public Produto(int id, string nome, double preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}
