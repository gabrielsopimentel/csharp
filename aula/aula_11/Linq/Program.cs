namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> nomes = new List<string>() { "João", "Breno", "Julia", "Samantha", "Vitor1", "Vitor2", "Victor", "Mateus", "Mateus", "Karina", "Carolina" };

            var numerosAoCubo = numeros.Select(n => Math.Pow(n, 3));

            numerosAoCubo.ToList().ForEach(numero => Console.WriteLine(numero));
            Console.WriteLine("Números elevados ao cubo: " + string.Join(", ", numerosAoCubo));

            var numerosImpares = from numero in numeros
                                 where numero % 2 != 0
                                 select (numero);
            Console.WriteLine("Números impares: " + string.Join(", ", numerosImpares));

            var nomesIniciamMV = (from nome in nomes
                                  where nome.StartsWith('M') ||
                                         nome.StartsWith('V')
                                  select nome).ToList();

            nomesIniciamMV.ForEach(n => Console.WriteLine(n)); //da pra converter pra lista depois do ponto também

            Console.WriteLine("Nomes que iniciam com a letra m ou v: " + string.Join(", ", nomesIniciamMV));

            var nomesC = from nome in nomes
                         where nome.ToUpper().Contains("C")
                         select (nome);

            Console.WriteLine("Nomes que iniciam com a letra c: " + string.Join(", ", nomesC));

            var numerosOrdemAscendente = from numero in numeros
                                         orderby numero
                                         select (numero);
            Console.WriteLine("Números crescente: " + string.Join(", ", numerosOrdemAscendente));

            var numerosOrdemDescendente = from numero in numeros
                                          orderby numero descending
                                          select (numero);
            Console.WriteLine("Números crescente: " + string.Join(", ", numerosOrdemDescendente));

            var nomesSemRepeticao = from nome in nomes
                                    .Distinct()
                                    select (nome);

            Console.WriteLine("Nomes sem duplicidade: " + string.Join(", ", nomesSemRepeticao));

            var contarVitors = nomes.Count(n => n.Contains("Vitor"));

            Console.WriteLine("Total de pessoas chamadas Vitor: " + contarVitors);

            var primeiroVitor = nomes.First(n => n.Contains("Vitor"));

            Console.WriteLine("Primeiro Vitor: " + primeiroVitor);
        }
    }
}