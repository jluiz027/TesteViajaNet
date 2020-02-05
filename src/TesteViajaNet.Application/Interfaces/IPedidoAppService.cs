using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;

namespace TesteViajaNet.Application.Interfaces
{
    public interface IPedidoAppService
    {
        void SalvarPedido(Pedido pedido);
    }
}
