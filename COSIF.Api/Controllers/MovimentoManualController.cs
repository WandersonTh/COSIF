using COSIF.Api.Models;
using COSIF.Api.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COSIF.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovimentoManualController : ControllerBase
    {
        private IMoviementoManualRepository moviementoManualRep;
        
        [HttpPost]
        public IActionResult Adicionar([FromBody] Movimento_Manual model)
        {
            try
            {
                moviementoManualRep = new MovimentoManualRepository();
                int id = moviementoManualRep.Parsistir(model);
                if (id < 0)
                    return BadRequest("Não foi possivel adicionar novo item, verifique os dados e tente novamente.");
                return Ok(id);
            }
            catch (Exception)
            {
                return BadRequest("Erro Interno ao processar requisição, contate o Administrador de Sistema.");
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                moviementoManualRep = new MovimentoManualRepository();
                IEnumerable<Movimento_Manual> ret = moviementoManualRep.Listar();

                return Ok(ret);
            }
            catch (Exception)
            {

                return BadRequest("Erro Interno ao processar requisição, contate o Administrador de Sistema.");
            }
        }
    }
}
