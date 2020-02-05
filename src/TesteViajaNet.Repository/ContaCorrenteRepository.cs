using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Domain.Entities;
using TesteDBServer.Domain.Interfaces;
using TesteDBServer.Repository.Context.Mysql;

namespace TesteDBServer.Repository
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        private TesteDBServerContext _context;
        public ContaCorrenteRepository(TesteDBServerContext testeDBServerContext)
        {
            _context = testeDBServerContext;
        }
        public ContaCorrente ObterContaCorrente(string contaCorrenteId)
        {
            var contaCorrente = _context.ContaCorrente.Find(contaCorrenteId);
            return contaCorrente;
        }

    }
}
