using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class PessoaFisica : Cliente
    {
        private string cpf;
        public PessoaFisica(string rg, string nome, string telefone, string email, string nascimento, string cpf) : base(rg, nome, telefone, email, nascimento)
        {
            this.cpf = cpf;
        }

        public string GetCpf() { return cpf; }
        public void SetCpf(string cpf) {  this.cpf = cpf; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Número do cpf: {this.cpf}");
        }
    }
}
