using FarmaciaC.Model;
using FarmaciaC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FarmaciaC.Controller
{
    public class ProdutoController : IProdutoRepository
    {
        private readonly List<Produto> listaProdutos = new();
        int id = 0;
        public void Atualizar(Produto produto)
        {
            var buscaProduto = BuscarNaCollection(produto.Id);

            if (buscaProduto is not null)
            {
                var index = listaProdutos.IndexOf(buscaProduto);
                listaProdutos[index] = produto;
                Console.WriteLine($"O produto numero {produto.Id} foi atualizada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta {id} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void Cadastrar(Produto produto)
        {
            listaProdutos.Add(produto);
            Console.WriteLine("Produto criado com sucesso!");
        }

        public void Deletar(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto is not null)
            {
                if (listaProdutos.Remove(produto) == true)
                    Console.WriteLine($"O produto número {id} foi apagado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto {id} não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void ListarTodas()
        {
            foreach (var produto in listaProdutos)
            {
                produto.Visualizar();
            }
        }

        public void ProcurarPorN(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto is not null)
                produto.Visualizar();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produtoo {id} não foi encontrado!");
                Console.ResetColor();
            }
        }

        public int GerarNumero()
        {
            return ++id;
        }

        public Produto? BuscarNaCollection(int id)
        {
            foreach (var produto in listaProdutos)
            {
                if (produto.Id == id)
                    return produto;
            }
            return null;
        }
    }
}
