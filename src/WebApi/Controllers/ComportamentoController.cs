using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteViajaNet.Application.Interfaces;
using TesteViajaNet.Domain.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComportamentoController : ControllerBase
    {
        private readonly IComportamentoAppService _comportamentoAppService;
        public ComportamentoController(IComportamentoAppService comportamentoAppService)
        {
            _comportamentoAppService = comportamentoAppService;
        }

        [HttpPost, Route("Salvar")]
        public IActionResult Post([FromBody] Comportamento comportamento)
        {
            try
            {
                _comportamentoAppService.SalvarComportamento(comportamento);
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status200OK);
            }
            catch (Exception e)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest, e.Message);
            }


        }
    }
}