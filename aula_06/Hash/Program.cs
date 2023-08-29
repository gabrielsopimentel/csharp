namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNomes = new HashSet<string>()
            {
                "Allan",
                "Robson",
                "João",
                "Ingrid",
                "Allan",
                "Robson"
            };

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            setNomes.Add("Samantha");
            setNomes.Add(null);
            setNomes.Add("Julia");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

                Console.WriteLine("O nome Julia existe? " + setNomes.Contains("Julia"));

            setNomes.Remove("João");

            setNomes.Add("Julia");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            //Converter HashSet em uma List
            List<string> hashList = setNomes.ToList();

            hashList.Sort();

            foreach (var hash in hashList)
            {
                Console.WriteLine(hash);
            }
        }
    }
}