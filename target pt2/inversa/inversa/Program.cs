namespace inversa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "target";

            string invertida = InversorString(original);

            Console.WriteLine("String original: " + original);
            Console.WriteLine("String invertida: " + invertida);
        }
        static string InversorString(string s)
        {
            string invertida = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                invertida += s[i];
            }

            return invertida;
        }
    }
}
