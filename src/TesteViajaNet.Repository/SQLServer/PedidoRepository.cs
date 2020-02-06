using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;
using TesteViajaNet.Repository.Context.SqlServer;

namespace TesteViajaNet.Repository.SQLServer
{
    public class PedidoRepository : IPedidoRepository
    {
        public PedidoRepository()
        {

        }
        public void SalvarPedido(Pedido pedido)
        {
            using (TesteViajaNetContext testeViajaNetContext = new TesteViajaNetContext())
            {
                testeViajaNetContext.pedido.Add(pedido);
                testeViajaNetContext.SaveChanges();
            }
        }
    }
}
