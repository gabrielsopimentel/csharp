using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Vendedor : Funcionario
    {
        private float venda;
        public Vendedor(string matricula, string nome, string telefone, string email, string nascimento, float venda) : base(matricula, nome, telefone, email, nascimento)
        {
            this.venda = venda;
        }

        public float GetVenda() {  return venda; }
        public void SetVenda(float venda) {  this.venda = venda; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"{(this.venda).ToString(format:"C")}");
        }
    }
}
