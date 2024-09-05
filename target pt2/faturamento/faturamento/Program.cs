using Newtonsoft.Json;

namespace faturamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("faturamento.json");
            List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);

            double menorValor = double.MaxValue;
            double maiorValor = double.MinValue;
            double somaFaturamento = 0;
            int diasComFaturamento = 0;

            foreach (var faturamento in faturamentos)
            {
                if (faturamento.valor > 0)
                {
                    if (faturamento.valor < menorValor)
                        menorValor = faturamento.valor;

                    if (faturamento.valor > maiorValor)
                        maiorValor = faturamento.valor;

                    somaFaturamento += faturamento.valor;
                    diasComFaturamento++;
                }
            }

            double mediaFaturamento = somaFaturamento / diasComFaturamento;

            int diasAcimaDaMedia = 0;
            foreach (var faturamento in faturamentos)
            {
                if (faturamento.valor > mediaFaturamento)
                    diasAcimaDaMedia++;
            }

            Console.WriteLine($"Menor valor de faturamento: {menorValor.ToString("C2")}");
            Console.WriteLine($"Maior valor de faturamento: {maiorValor.ToString("C2")}");
            Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");

        }
    }
}
