using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triatleta
{
    public class Triatleta : Pessoa, ICliclista, ICorredor, INadador
    {
        public Triatleta(string nome) : base(nome)
        {
        }

        public void Aquecer()
        {
            Console.WriteLine("Aquecendo...");
        }

        public void Correr()
        {
            Console.WriteLine("Correndo...");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando...");
        }

        public void Pedalar()
        {
            Console.WriteLine("Pedalando...");
        }
    }
}
