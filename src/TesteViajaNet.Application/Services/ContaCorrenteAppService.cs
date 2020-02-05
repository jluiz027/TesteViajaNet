using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Application.Interfaces;
using TesteDBServer.Domain.Entities;
using TesteDBServer.Domain.Interfaces.Services;

namespace TesteDBServer.Application.Services
{
    public class ContaCorrenteAppService : IContaCorrenteAppService
    {
        IContaCorrenteService _contaCorrenteService;
        public ContaCorrenteAppService(IContaCorrenteService contaCorrenteService)
        {
            _contaCorrenteService = contaCorrenteService;
        }
        public List<ContaCorrente> obtemContasCorrentes()
        {
            throw new NotImplementedException();
        }

        public decimal obtemSaldo(string contaCorrenteId)
        {
            var saldo = _contaCorrenteService.ObterSaldo(contaCorrenteId);
            return saldo;
        }
    }
}
