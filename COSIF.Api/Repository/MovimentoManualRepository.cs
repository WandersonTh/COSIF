using COSIF.Api.Context;
using COSIF.Api.Models;
using System.Collections.Generic;

namespace COSIF.Api.Repository
{
    public class MovimentoManualRepository : IMoviementoManualRepository
    {
        private readonly CosifContext _contexto;

        public MovimentoManualRepository()
        {
            _contexto = new CosifContext();
        }

        public IEnumerable<Movimento_Manual> Listar()
        {
            return _contexto.Set<Movimento_Manual>();
        }

        public int Parsistir(Movimento_Manual movimento)
        {
            _contexto.Add(movimento);
            return _contexto.SaveChanges();
        }
    }
}
