using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;

namespace TesteViajaNet.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        void SalvarPedido(Pedido pedido);
    }
}
