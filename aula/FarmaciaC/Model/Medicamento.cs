using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaC.Model
{
    public class Medicamento : Produto
    {
        public string Generico { get; set; } = string.Empty;
        public Medicamento(int id, string nome, int tipo, decimal preco, string generico) : base(id, nome, tipo, preco)
        {
            Generico = generico;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Genérico: {Generico}");
        }
    }
}
