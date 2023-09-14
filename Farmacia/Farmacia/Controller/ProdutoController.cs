using Farmacia.Model;
using Farmacia.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Farmacia.Controller
{
    internal class ProdutoController : IProdutoRepository
    {
        private readonly List<Produto> listaProdutos = new List<Produto>();

        int num = 0;

        public void Atualizar(Produto produto)
        {
            var busca = BuscarColletion(produto.GetId());

            if (busca != null)
            {
                var i = listaProdutos.IndexOf(busca);
                listaProdutos[i] = produto;
                Console.WriteLine($"o produto {produto.GetId()} foi atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine($"o produto {num} não foi encontrado!");
            }
        }

        public void ConsultarPorId(int id)
        {
            var produto = BuscarColletion(id);

            if (produto != null)
            {
                produto.Visualizar();
            }
            else
            {
                Console.WriteLine($"o produto {num} não foi encontrado!");
            }
        }

        public void CriarProduto(Produto produto)
        {
            listaProdutos.Add(produto);
            Console.WriteLine($"o produto {produto.GetId()} foi inserido com sucesso!");
        }

        public void Deletar(int id)
        {
            var produto = BuscarColletion(id);

            if (produto != null)
            {
                if (listaProdutos.Remove(produto) == true)
                {
                    Console.WriteLine($"o produto {num} foi apagado com sucesso!");
                }
            }
            else
            {
                Console.WriteLine($"o produto {num} não foi encontrado!");
            }
        }

        public void ListarProdutos()
        {
            foreach (var produto in listaProdutos)
            {
                produto.Visualizar();
            }
        }

        public Produto BuscarColletion(int id)
        {
            foreach (var produto in listaProdutos)
            {
                if (produto.GetId() == id)
                    return produto;
            }
            return null;
        }

        public int GerarNumero()
        {
            return ++num;
        }
    }
}
