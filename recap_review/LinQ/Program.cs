namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numerosAoCubo = numeros.Select(e => Math.Pow(e, 3));

            Console.WriteLine("\nTodos os Números elevados ao cubo: " + string.Join(", ", numerosAoCubo));

            List<string> estados = new List<string> { "São Paulo", "Rio de Janeiro", "Minas Gerais", "Espirito Santo", "São Paulo", "Rio de Janeiro", "Minas Gerais", "São Paulo", "Rio de Grande do Sul" };

            var estadosContemRio = from estado in estados
                                   where estado.Contains("Rio")
                                   select estado.ToUpper();

            Console.WriteLine("\nEstados que contém a palvra Rio: " + string.Join(", ", estadosContemRio));
        }
    }
}