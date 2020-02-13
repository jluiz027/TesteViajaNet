using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Application.Interfaces;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;


namespace TesteViajaNet.Application.Services
{
    public class PedidoAppService : IPedidoAppService
    {
        IPedidoRepository _pedidoRepository;
        //SQLServerConnectionConfig _sQLServerConnectionConfig;
        public PedidoAppService(IPedidoRepository pedidoRepository)
        {
            //_sQLServerConnectionConfig = sQLServerConnectionConfig;
            _pedidoRepository = pedidoRepository;
        }
        public void SalvarPedido(Pedido pedido)
        {
            _pedidoRepository.SalvarPedido(pedido);
        }
    }
}
