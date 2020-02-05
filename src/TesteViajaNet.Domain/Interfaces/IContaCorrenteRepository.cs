using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Domain.Entities;

namespace TesteDBServer.Domain.Interfaces
{
    public interface IContaCorrenteRepository
    {
        ContaCorrente ObterContaCorrente(string contaCorrenteId);
    }
}
