using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;
using TesteViajaNet.Repository.Context.SqlServer;

namespace TesteViajaNet.Repository.SQLServer
{
    public class ComportamentoRepository : IComportamentoRepository
    {
        public void Salvar(Comportamento comportamento)
        {
            using (TesteViajaNetContext testeViajaNetContext = new TesteViajaNetContext())
            {
                comportamento.Id = new Guid().ToString();
                testeViajaNetContext.comportamento.Add(comportamento);
                testeViajaNetContext.SaveChanges();
            }
            
        }
    }
}
