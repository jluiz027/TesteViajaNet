using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteDBServer.Domain.Entities;
using TesteDBServer.Domain.Interfaces;
using TesteDBServer.Repository.Context.Mysql;

namespace TesteDBServer.Repository
{
    public class LancamentoRepository : ILancamentoRepository
    {
        private TesteDBServerContext _context;
        public LancamentoRepository(TesteDBServerContext testeDBServerContext)
        {
            _context = testeDBServerContext;
        }

        public void ConluirTransacao()
        {
            _context.ConluirTransacao();
        }

        public void gravarLancamento(Lancamento lancamento)
        {
            
            _context.Lancamento.Add(lancamento);
            _context.SaveChanges();
        }

        public void IniciarTransacao()
        {
            _context.IniciarTransacao();
        }


        public List<Lancamento> ObterLancamentos(string contaCorrenteId)
        {
            var lancamentos = _context.Lancamento.Where(l => l.idContaCorrente == contaCorrenteId);
            return lancamentos.ToList();
        }

        public void ReverterTransacao()
        {
            _context.ReverterTransacao();
        }
    }
}
