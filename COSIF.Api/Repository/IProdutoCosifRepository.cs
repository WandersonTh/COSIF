using COSIF.Api.Models;
using System.Collections.Generic;

namespace COSIF.Api.Repository
{
    public interface IProdutoCosifRepository
    {
        IEnumerable<Produto_Cosif> Listar();
    }
}
