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
    public class ProdutoCosifController : ControllerBase
    {
        IProdutoCosifRepository ProdutoCosifRep;

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                ProdutoCosifRep = new ProdutoCosifRepository();
                IEnumerable<Produto_Cosif> ret = ProdutoCosifRep.Listar();
                return Ok(ret);
            }
            catch (Exception)
            {
                return BadRequest("Erro Interno ao processar requisição, contate o administrador do Sistema.");
            }
        }
    }
}
