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
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoAppService _pedidoAppService;
        public PedidoController(IPedidoAppService pedidoAppService)
        {
            _pedidoAppService = pedidoAppService;
        }
        [HttpPost, Route("Salvar")]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            try
            {
                _pedidoAppService.SalvarPedido(pedido);
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status200OK);
            }
            catch (Exception e)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest, e.Message);
            }


        }
    }
}