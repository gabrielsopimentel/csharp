using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2.Namespace1
{
    public class Classe2
    {
        public static void MetodoPublico()
        {
            Console.WriteLine("Método Público - Classe 2");
        }
        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe 2");
        }
        protected static void MetodoProtected()
        {
            Console.WriteLine("Método Protegido - Classe 2");
        }
        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado - Classe 2");
        }
    }
}
