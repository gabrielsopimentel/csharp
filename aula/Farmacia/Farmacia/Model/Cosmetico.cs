using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public class Cosmetico : Produto
    {
        private string fragancia;

        public Cosmetico(int id, string nome, int tipo, decimal preco, string fragancia) : base(id, nome, tipo, preco)
        {
            this.fragancia = fragancia;
        }

        public string GetFragancia() { return fragancia; }
        public void SetFragancia(string fragancia) { this.fragancia = fragancia; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"{this.fragancia}");
        }
    }
}
