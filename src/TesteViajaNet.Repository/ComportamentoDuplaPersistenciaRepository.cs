using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;

namespace TesteViajaNet.Repository
{
    public class ComportamentoDuplaPersistenciaRepository : IComportamentoRepository
    {
        public void Salvar(Comportamento comportamento)
        {
            //Salva no SQL Server
            TesteViajaNet.Repository.SQLServer.ComportamentoRepository comportamentoRepositorySqlServer = new SQLServer.ComportamentoRepository();
            comportamentoRepositorySqlServer.Salvar(comportamento);

            //Salva no Couchbase
            TesteViajaNet.Repository.Couchbase.ComportamentoRepository comportamentoRepositoryCouchbase = new TesteViajaNet.Repository.Couchbase.ComportamentoRepository();
            comportamentoRepositoryCouchbase.Salvar(comportamento);
        }
    }
}
