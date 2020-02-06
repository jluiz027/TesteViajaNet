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
    public class ComportamentoRepository : IComportamentoRepository
    {
       
        public void Salvar(Comportamento comportamento)
        {
            var config = new ClientConfiguration
            {
                Servers = new List<Uri> {
                   new Uri("http://192.168.99.100:8091")
               }
            };

            var cluster = new Cluster(config);
            var credentials = new PasswordAuthenticator("Administrator", "123456");
            cluster.Authenticate(credentials);

            var bucket = cluster.OpenBucket("Comportamento");

            bucket.Insert(new Document<dynamic> { Id = Guid.NewGuid().ToString(), Content = comportamento });

        }
    }
}
