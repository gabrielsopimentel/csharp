using Farmacia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Repository
{
    public interface IProdutoRepository
    {
        public void CriarProduto(Produto produto);
        public void ListarProdutos();
        public void ConsultarPorId(int id);
        public void Atualizar(Produto produto);
        public void Deletar(int id);
    }
}
