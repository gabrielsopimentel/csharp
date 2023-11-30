using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    public class Classe1
    {
        public static void MetodoPublico()
        {
            Console.WriteLine("Método Público - Classe 1");
        }
        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe 1");
        }
        protected static void MetodoProtected()
        {
            Console.WriteLine("Método Protegido - Classe 1");
        }
        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado - Classe 1");
        }
    }
}
