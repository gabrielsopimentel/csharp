using FarmaciaC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaC.Repository
{
    internal interface IProdutoRepository
    {
        public void ProcurarPorN(int id);
        public void ListarTodas();
        public void Cadastrar(Produto produto);
        public void Atualizar(Produto produto);
        public void Deletar(int id);
    }
}
