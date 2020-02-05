using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Domain.Entities;

namespace TesteDBServer.Domain.Interfaces.Services
{
    public interface IContaCorrenteService
    {
        ContaCorrente ObterContaCorrente(string contaCorrenteId);

        decimal ObterSaldo(string contaCorrenteId);
    }
}
