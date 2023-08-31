using Metodos2.Namespace1;
using System.Security.Cryptography.X509Certificates;

namespace Metodos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodoInternal();
            MetodoPublico();
            MetodoProtected();
            MetodoPrivado();

            Classe1.MetodoPublico();
            Classe1.MetodoInternal();
            //Classe1.MetodoProtected();
            //Classe1.MetodoPrivado();

            Classe2.MetodoPublico();
            Classe2.MetodoInternal();
            //Classe2.MetodoProtected();
            //Classe2.MetodoPrivado();
        }
        public static void MetodoPublico()
        {
            Console.WriteLine("Método Público - Classe Program");
        }
        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe Program");
        }
        protected static void MetodoProtected()
        {
            Console.WriteLine("Método Protegido - Classe Program");
        }
        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado - Classe Program");
        }
    }
}