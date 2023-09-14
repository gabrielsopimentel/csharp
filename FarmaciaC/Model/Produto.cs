using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaC.Model
{
    public abstract class Produto
    {

        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Tipo { get; set; }
        public decimal Preco { get; set; }
        public Produto(int id, string nome, int tipo, decimal preco)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            Preco = preco;
        }

        public virtual void Visualizar()
        {
            string tipo = "";
            switch (Tipo)
            {
                case 1:
                    tipo = "Mecamento";
                    break;
                case 2:
                    tipo = "Cosmético";
                    break;
                default:
                    break;
            }
            Console.WriteLine("**************");
            Console.WriteLine("Dados do produto");
            Console.WriteLine("**************");
            Console.WriteLine($"Id do produto: {Id}");
            Console.WriteLine($"Nome do produto: {Nome}");
            Console.WriteLine($"Tipo do produto: {tipo}");
            Console.WriteLine($"Preço do produto: {Preco}");
        }
    }
}
