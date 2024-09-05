namespace total
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> faturamentoEstados = new Dictionary<string, double>()
            {
                {"SP", 67836.43},
                {"RJ", 36678.66},
                {"MG", 29229.88},
                {"ES", 27165.48},
                {"Outros", 19849.53}
            };

            double faturamentoTotal = 0;
            foreach (var faturamento in faturamentoEstados.Values)
            {
                faturamentoTotal += faturamento;
            }

            foreach (var estado in faturamentoEstados)
            {
                double percentual = (estado.Value / faturamentoTotal) * 100;
                Console.WriteLine($"{estado.Key}: {percentual:F2}% de representação no faturamento total.");
            }
        }
    }
}
