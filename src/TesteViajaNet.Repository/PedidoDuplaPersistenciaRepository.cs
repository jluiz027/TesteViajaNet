using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;

namespace TesteViajaNet.Repository
{
    public class DuplaPersistenciaPedidoRepository : IPedidoRepository
    {
        public void SalvarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
