using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;

namespace TesteViajaNet.Repository.RabbitMQ
{
    public class PedidoRepository : IPedidoRepository
    {
        private PushQueue<Pedido> _pushQueue;

        public PedidoRepository()
        {
            _pushQueue = new PushQueue<Pedido>();
        }

        public void SalvarPedido(Pedido pedido)
        {
            _pushQueue.PushMessage(pedido, "Pedido");
        }
    }
}
