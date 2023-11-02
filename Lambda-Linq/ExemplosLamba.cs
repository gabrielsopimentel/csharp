using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class ExemplosLamba
    {
        public static void soma()
        {
            // Esta expressão lambda é explicitamente convertida para uma Função que recebe
            // 2 argumentos int e retorna um int.
            Func<int, int, int> somar = (a, b) => a + b;

            int resultado = somar(5, 3);
            Console.WriteLine(resultado);
        }

        public static void encontreACor()
        {
            List<string> cores = new List<string> { "vermelho", "azul", "verde", "amarelo" };

            // Neste exemplo, a expressão lambda cor => cor == "verde" é usada como um condição no método Find
            // para encontrar a primeira ocorrência da cor "verde" na lista.
            string corEncontrada = cores.Find(cor => cor == "verde");
            Console.WriteLine(corEncontrada);

            /*
            
            cor => cor == "verde" poderia se escrito dessa forma sem lambda:

            string corEncontrada = cores.Find(EncontrarVerde);
            Console.WriteLine(corEncontrada); // Saída: verde

            static bool EncontrarVerde(string cor)
            {
                return cor == "verde";
            }
            */

        }

        public static void elevarAoQuadrado(int num)
        {
            //Neste exemplo, a expressão lambda x => x * x define uma função que recebe
            //um número e retorna o seu quadrado.
            Func<int, int> quadrado = x => x * x;

            int resultado = quadrado(num);
            Console.WriteLine(resultado);

        }
    }
}
