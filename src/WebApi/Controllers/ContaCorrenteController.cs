using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteDBServer.Application.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly IContaCorrenteAppService _contaCorrenteAppService;
        public ContaCorrenteController(IContaCorrenteAppService contaCorrenteAppService)
        {
            _contaCorrenteAppService = contaCorrenteAppService;
        }

        // POST api/values
        [HttpGet, Route("Saldo")]
        public IActionResult Get(string contaCorrenteId)
        {
            try
            {
                var saldo = _contaCorrenteAppService.obtemSaldo(contaCorrenteId);
                return new JsonResult(saldo);
                //return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status200OK, $"");
            }
            catch (Exception e)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest, e.Message);
            }


        }
    }
}