using COSIF.Api.Models;
using COSIF.Api.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace COSIF.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        IProdutoRepository ProdutoRep;

        [HttpGet]      
        public IActionResult Get()
        {
            try
            {
                ProdutoRep = new ProdutoRepository();
                IEnumerable<Produto> ret = ProdutoRep.Listar();
                return Ok(ret);
            }
            catch (Exception)
            {
                return BadRequest("Erro Interno ao processar requisição, contate o Administrador de Sistema.");
            }
        }  
    }
}
