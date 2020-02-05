using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Application.Interfaces;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;
//using TesteViajaNet.Domain.

namespace TesteViajaNet.Application.Services
{
    class PedidoAppService : IPedidoAppService
    {
        IPedidoRepository _pedidoRepository;
        public PedidoAppService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public void SalvarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
