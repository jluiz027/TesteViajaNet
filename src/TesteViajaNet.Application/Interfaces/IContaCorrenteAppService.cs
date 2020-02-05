using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Domain.Entities;

namespace TesteDBServer.Application.Interfaces
{
    public interface IContaCorrenteAppService
    {
        decimal obtemSaldo(string contaCorrenteId);

        List<ContaCorrente> obtemContasCorrentes();
    }
}
