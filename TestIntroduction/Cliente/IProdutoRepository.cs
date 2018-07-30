using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    public interface IProdutoRepository : IRepository<ProdutoModel>
    {
        ProdutoModel ObterPorNome(string nome);
    }
}
