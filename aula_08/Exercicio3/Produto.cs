using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Produto
    {
        private int codigo;
        private string descricao;
        private float precoCusto;
        private float precoVenda;
        private int quantidadeEstoque;

        public Produto(int codigo, string descricao, float precoCusto, float precoVenda, int quantidadeEstoque)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.precoCusto = precoCusto;
            this.precoVenda = precoVenda;
            this.quantidadeEstoque = quantidadeEstoque;
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string GetDescricao()
        {
            return descricao;
        }

        public void SetDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public float GetPrecoCusto()
        {
            return precoCusto;
        }

        public void SetPrecoCusto(float precoCusto)
        {
            this.precoCusto = precoCusto;
        }

        public float GetPrecoVenda()
        {
            return precoVenda;
        }

        public void SetPrecoVenda(float precoVenda)
        {
            this.precoVenda = precoVenda;
        }

        public int GetQuantidadeEstoque()
        {
            return quantidadeEstoque;
        }

        public void SetQuantidadeEstoque(int quantidadeEstoque)
        {
            this.quantidadeEstoque = quantidadeEstoque;
        }

        public void Visualizar()
        {

            Console.WriteLine("**************");
            Console.WriteLine("Dados do funcionário");
            Console.WriteLine("**************");
            Console.WriteLine($"Código do produto: {this.codigo}");
            Console.WriteLine($"Descrição do produto: {this.descricao}");
            Console.WriteLine($"Preço de custo: {(this.precoCusto).ToString(format:"C")}");
            Console.WriteLine($"Preço de venda: {(this.precoVenda).ToString(format:"C")}");
            Console.WriteLine($"Quantidade no estoque: {this.quantidadeEstoque}");
        }
    }
}
