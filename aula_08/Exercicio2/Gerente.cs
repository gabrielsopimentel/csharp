using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Gerente : Funcionario
    {
        private bool CancelaVenda;
        public Gerente(string matricula, string nome, string telefone, string email, string nascimento, bool cancelaVenda) : base(matricula, nome, telefone, email, nascimento)
        {
            this.CancelaVenda = cancelaVenda;
        }

        public bool GetCancelaVenda() { return CancelaVenda; }
        public void SetCancelaVenda(bool cancelaVenda) { this.CancelaVenda = cancelaVenda; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Venda: {this.CancelaVenda}");
        }
    }
}
