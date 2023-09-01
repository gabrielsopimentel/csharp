using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    public class Transporte
    {
        private int capacidade;

        public Transporte(int capacidade)
        {
            this.capacidade = capacidade;
        }

        public int GetCapacidade() { return capacidade; }

        public void SetCapacidade(int capacidade) { this.capacidade = capacidade; }

        public virtual void Visualizar()
        {
            Console.Write($"Meio de transporte: {this.capacidade} ");
        }
    }

}
