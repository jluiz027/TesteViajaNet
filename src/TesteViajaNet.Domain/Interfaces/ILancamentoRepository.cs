using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Domain.Entities;

namespace TesteDBServer.Domain.Interfaces
{
    public interface ILancamentoRepository
    {
        void gravarLancamento(Lancamento lancamento);
        List<Lancamento> ObterLancamentos(string contaCorrenteId);
        void IniciarTransacao();
        void ConluirTransacao();
        void ReverterTransacao();
    }
}
