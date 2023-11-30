using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class ExemplosLinq
    {
        public static void elevarAoCubo()
        {
            List<int> numeros = new List<int>(){
                1,2,3,4,5,6,7,8,9,10
            };

            /* Aqui usamos método Select do LINQ para projetar (transformar) cada elemento da lista de numeros 
             * em seu valor elevado ao cubo. 
             * 
             * A expressão lambda e => Math.Pow(e, 3) é usada para realizar essa projeção. 
             * Ela recebe um elemento e da lista e retorna o valor de e elevado ao cubo usando a função Math.Pow.
             */
            var numerosAoCubo = numeros.Select(e => Math.Pow(e, 3));

            Console.WriteLine("\nTodos os Números elevados ao cubo: " + string.Join(", ", numerosAoCubo));
        }

        public static void estadosQueComecamComALetraR() {

            List<string> estados = new List<string>{
                "São Paulo", "Rio de Janeiro", "Minas Gerais", "Espirito Santo",
                "São Paulo", "Rio de Janeiro", "Minas Gerais", "São Paulo", "Rio de Grande do Sul"
            };

            /* A consulta LINQ é expressa no formato de consulta(query) usando a cláusula from para iterar sobre a Collection, 
             * a cláusula where para filtrar os estados que começam com 'R' 
             * e a cláusula select para selecionar os estados que atendem ao critério.
             */
            var estadosStartR = from estado in estados
                                where estado.StartsWith('R')
                                select estado;

            Console.WriteLine("\nEstados que começam com as letras R: " + string.Join(", ", estadosStartR));

        }

        public static void estadosQueContemAPalavraRio()
        {
            List<string> estados = new List<string>{
                "São Paulo", "Rio de Janeiro", "Minas Gerais", "Espirito Santo",
                "São Paulo", "Rio de Janeiro", "Minas Gerais", "São Paulo", "Rio de Grande do Sul"
            };

            /* A consulta LINQ é expressa no formato de consulta (query) usando a cláusula from, 
             * a cláusula where para filtrar os estados que contêm "Rio" 
             * e a cláusula select para selecionar os estados e transformar seus nomes em letras maiúsculas usando ToUpper().
             */
            var estadosContemRio = from estado in estados
                                   where estado.Contains("Rio")
                                   select estado.ToUpper();

            /* A consulta LINQ é executada e a variável estadosContemRio agora contém uma sequência dos estados 
             * que atendem ao critério de conter a palavra "Rio".
             */

            Console.WriteLine("\nEstados que contém a palvra Rio: " + string.Join(", ", estadosContemRio));
        }
    }
}
