using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExceptions_03
{
    public class ExcecaoSimples : Exception
    {
        public ExcecaoSimples() { }
        public ExcecaoSimples(string message) : base(message)
        {
            Console.Error.WriteLine(message);
            Console.WriteLine("Exceção definida pela pessoa desenvolvedora!");
        }
    }
}
