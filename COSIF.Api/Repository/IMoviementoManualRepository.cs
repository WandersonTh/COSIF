using COSIF.Api.Models;
using System.Collections.Generic;

namespace COSIF.Api.Repository
{
    public interface IMoviementoManualRepository
    {
        IEnumerable<Movimento_Manual> Listar();
        int Parsistir(Movimento_Manual movimento);
    }
}
