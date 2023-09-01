using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class PessoaJuridica : Cliente
    {
        private string cnpj;
        public PessoaJuridica(string rg, string nome, string telefone, string email, string nascimento, string cnpj) : base(rg, nome, telefone, email, nascimento)
        {
            this.cnpj = cnpj;
        }

        public string GetCnpj() { return cnpj; }
        public void SetCpnj(string cnpj) { this.cnpj = cnpj; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Número do cnpj: {this.cnpj}");

        }
    }
}
