using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Domain.Entities;

namespace TesteDBServer.Application.Interfaces
{
    public interface ILancamentoAppService
    {
        void RealizarTransferencia(Transferencia transferencia);
    }
}
