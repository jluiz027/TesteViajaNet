using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Application.Interfaces;
using TesteDBServer.Domain.Entities;
using Xunit;

namespace TesteDBServer.Test
{
    public class AoFazerTransferenciaEntreContas: IClassFixture<ServicesFixture>
    {
        private ServiceProvider _serviceProvider;

        public AoFazerTransferenciaEntreContas(ServicesFixture fixture)
        {
            _serviceProvider = fixture.ServiceProvider;
        }

        [Fact]
        public void ContaOrigemFicaComSaldoMenor()
        {

            var contextLancamento = _serviceProvider.GetService<ILancamentoAppService>();
            var contextContaCorrente = _serviceProvider.GetService<IContaCorrenteAppService>();
            var contaOrigemId = "25062513-09c8-11ea-a0aa-0242ac110005";
            var contaDestinoId = "e4ff1fa7-09c7-11ea-a0aa-0242ac110005";
            var saldoInicialContaCorrenteOrigem = contextContaCorrente.obtemSaldo(contaOrigemId);
            var valorDebito = 100;

            var transferencia = new Transferencia() {
                ContaOrigemId = contaOrigemId,
                ContaDestinoId = contaDestinoId,
                Valor = valorDebito
            };

            contextLancamento.RealizarTransferencia(transferencia);

            var testeVerificado = contextContaCorrente.obtemSaldo(contaOrigemId) == saldoInicialContaCorrenteOrigem - valorDebito;

            Assert.True(testeVerificado);
        }

        [Fact]
        public void ContadestinoFicaComSaldoMaior()
        {

            var contextLancamento = _serviceProvider.GetService<ILancamentoAppService>();
            var contextContaCorrente = _serviceProvider.GetService<IContaCorrenteAppService>();
            var contaOrigemId = "25062513-09c8-11ea-a0aa-0242ac110005";
            var contaDestinoId = "e4ff1fa7-09c7-11ea-a0aa-0242ac110005";
            var saldoInicialContaCorrenteDestino = contextContaCorrente.obtemSaldo(contaDestinoId);
            var valorCredito = 100;

            var transferencia = new Transferencia()
            {
                ContaOrigemId = contaOrigemId,
                ContaDestinoId = contaDestinoId,
                Valor = valorCredito
            };

            contextLancamento.RealizarTransferencia(transferencia);

            var testeVerificado = contextContaCorrente.obtemSaldo(contaOrigemId) == saldoInicialContaCorrenteDestino + valorCredito;

            Assert.True(testeVerificado);
        }
    }
}
