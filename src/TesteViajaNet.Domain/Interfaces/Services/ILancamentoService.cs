using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Domain.Entities;

namespace TesteDBServer.Domain.Interfaces.Services
{
    public interface ILancamentoService
    {
        void Transferir(string idContaOrigem, string idContaDestino, Decimal valor);

        List<Lancamento> ObterLancamentos(string contaCorrente);
    }
}
