using Couchbase;
using Couchbase.Authentication;
using Couchbase.Configuration.Client;
using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;

namespace TesteViajaNet.Repository.Couchbase
{
    public class PedidoRepository : IPedidoRepository
    {
        public void SalvarPedido(Pedido pedido)
        {
            var config = new ClientConfiguration
            {
                Servers = new List<Uri> {
                   new Uri("http://192.168.52.134:8091")
               }
            };

            var cluster = new Cluster(config);
            var credentials = new PasswordAuthenticator("teste", "admin@*0");
            cluster.Authenticate(credentials);

            var bucket = cluster.OpenBucket("ViajaNet");

            bucket.Insert(new Document<dynamic> { Id = Guid.NewGuid().ToString(), Content = pedido });

        }
    }
}
