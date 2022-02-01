using COSIF.Api.Context;
using COSIF.Api.Models;
using System;
using System.Collections.Generic;

namespace COSIF.Api.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly CosifContext _contexto ;
        
        public ProdutoRepository()
        {
            _contexto = new CosifContext();
        }
        
        public IEnumerable<Produto> Listar()
        {
            try
            {
                return _contexto.Set<Produto>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
