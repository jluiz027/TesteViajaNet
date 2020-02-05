using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Application.Interfaces;
using TesteDBServer.Domain.Entities;
using TesteDBServer.Domain.Interfaces;
using TesteDBServer.Domain.Interfaces.Services;

namespace TesteDBServer.Application.Services
{
    public class LancamentoAppService : ILancamentoAppService
    {
        ILancamentoRepository _lancamentoRepository;
        ILancamentoService _lancamentoService;
        public LancamentoAppService(ILancamentoRepository lancamentoRepository,
            ILancamentoService lancamentoService)
        {
            _lancamentoService = lancamentoService;
        }


        public void RealizarTransferencia(Transferencia transferencia)
        {
            _lancamentoService.Transferir(transferencia.ContaOrigemId, transferencia.ContaDestinoId, transferencia.Valor);
        }
    }
}
