using COSIF.Api.Context;
using COSIF.Api.Models;
using System.Collections.Generic;

namespace COSIF.Api.Repository
{
    public class ProdutoCosifRepository : IProdutoCosifRepository
    {
        private readonly CosifContext _contexto;
        
        public ProdutoCosifRepository()
        {
            _contexto = new CosifContext();
        }

        public IEnumerable<Produto_Cosif> Listar()
        {
            return _contexto.Set<Produto_Cosif>();
        }
    }
}
