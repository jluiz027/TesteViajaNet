using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Domain.Entities;
using TesteDBServer.Domain.Interfaces;
using TesteDBServer.Domain.Interfaces.Services;

namespace TesteDBServer.Domain.Services
{
    public class LancamentoService : ILancamentoService
    {
        ILancamentoRepository _lancamentoRepository;
        IContaCorrenteService _contaCorrenteService;
        public LancamentoService(ILancamentoRepository lancamentoRepository, IContaCorrenteService contaCorrenteService)
        {
            _lancamentoRepository = lancamentoRepository;
            _contaCorrenteService = contaCorrenteService;
        }
        //private void Credito(string contaCorrenteId, decimal valor, string idTransacao)
        private void Credito(string contaCorrenteId, decimal valor)
        {
            try
            {
                
                var lancamento = new Lancamento();
                lancamento.idContaCorrente = contaCorrenteId;
                lancamento.id = Guid.NewGuid().ToString();
                lancamento.tipoLancamento = TipoLancamento.Credito;
                lancamento.valor = valor;
                _lancamentoRepository.gravarLancamento(lancamento);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        //private void Debito(string contaCorrenteId, decimal valor, string idTransacao)
        private void Debito(string contaCorrenteId, decimal valor)
        {
            try
            {
                var saldoContaCorrente = _contaCorrenteService.ObterSaldo(contaCorrenteId);
                if (saldoContaCorrente < valor)
                {
                    throw new Exception("Saldo insuficiente na conta origem");
                }
                var lancamento = new Lancamento();
                lancamento.idContaCorrente = contaCorrenteId;
                lancamento.id = Guid.NewGuid().ToString();
                lancamento.tipoLancamento = TipoLancamento.Debito;
                lancamento.valor = valor;
                _lancamentoRepository.gravarLancamento(lancamento);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao completar transação: {e.Message}", e);
            }
            
        }

        public List<Lancamento> ObterLancamentos(string contaCorrente)
        {
            throw new NotImplementedException();
        }

        public void Transferir(string contaOrigem, string contaDestino, decimal valor)
        {
            _lancamentoRepository.IniciarTransacao();

            try
            {
                Credito(contaDestino, valor);
                Debito(contaOrigem, valor);
            }
            catch (Exception)
            {
                _lancamentoRepository.ReverterTransacao();
                throw;
            }

            _lancamentoRepository.ConluirTransacao();
        }
    }
}
