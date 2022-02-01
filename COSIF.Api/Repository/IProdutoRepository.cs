using COSIF.Api.Models;
using System.Collections.Generic;

namespace COSIF.Api.Repository
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Listar();
    }
}
