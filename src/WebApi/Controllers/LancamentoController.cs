using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteDBServer.Application.Interfaces;
using TesteDBServer.Domain.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancamentoController : ControllerBase
    {
        private readonly ILancamentoAppService _lancamentoService;
        public LancamentoController(ILancamentoAppService lancamentoService)
        {
            _lancamentoService = lancamentoService;
        }

        // POST api/values
        [HttpPost, Route("Transferencia")]
        public IActionResult Post([FromBody] Transferencia transferencia)
        {
            try
            {
                _lancamentoService.RealizarTransferencia(transferencia);
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status200OK);
            }
            catch (Exception e)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest, e.Message);
            }
            
            
        }
    }
}