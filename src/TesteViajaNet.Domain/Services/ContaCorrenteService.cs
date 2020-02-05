using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Domain.Entities;
using TesteDBServer.Domain.Interfaces;
using TesteDBServer.Domain.Interfaces.Services;

namespace TesteDBServer.Domain.Services
{
    public class ContaCorrenteService : IContaCorrenteService
    {
        private readonly IContaCorrenteRepository _contaCorrenteRepository;
        private readonly ILancamentoRepository _lancamentoRepository;

        public ContaCorrenteService(IContaCorrenteRepository contaCorrenteRepository, 
            ILancamentoRepository lancamentoRepository)
        {
            _contaCorrenteRepository = contaCorrenteRepository;
            _lancamentoRepository = lancamentoRepository;
        }

        public ContaCorrente ObterContaCorrente(string contaCorrenteId)
        {
            var contaCorrente = _contaCorrenteRepository.ObterContaCorrente(contaCorrenteId);
            return contaCorrente;
        }

        public decimal ObterSaldo(string contaCorrenteId)
        {
            var listaLancamento = _lancamentoRepository.ObterLancamentos(contaCorrenteId);
            var contaCorrente = ObterContaCorrente(contaCorrenteId);
            decimal saldo = contaCorrente.saldoInicial;

            foreach (var lancamento in listaLancamento)
            {
                if (lancamento.tipoLancamento == TipoLancamento.Credito)
                {
                    saldo += lancamento.valor;
                }
                else
                {
                    saldo -= lancamento.valor;
                }
            }

            return saldo;
        }
    }
}
