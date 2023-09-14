using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public abstract class Produto
    {
        private int id;
        private string nome;
        private int tipo;
        private decimal preco;

        protected Produto(int id, string nome, int tipo, decimal preco)
        {
            this.id = id;
            this.nome = nome;
            this.tipo = tipo;
            this.preco = preco;
        }

        public int GetId() { return id; }
        public string GetNome() { return nome; }
        public int GetTipo() { return tipo; }
        public decimal GetPreco() { return preco; }

        public void SetId(int id) { this.id = id; }
        public void SetNome(string nome) { this.nome = nome; }
        public void SetTipo(int tipo) { this.tipo = tipo; }
        public void SetPreco(decimal preco) { this.preco = preco; }

        public virtual void Visualizar()
        {
            Console.WriteLine($"{this.id}");
            Console.WriteLine($"{this.nome}");
            Console.WriteLine($"{this.tipo}");
            Console.WriteLine($"{this.preco}");
        }

    }
}
