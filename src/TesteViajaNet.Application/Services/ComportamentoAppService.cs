using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Application.Interfaces;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;

namespace TesteViajaNet.Application.Services
{
    public class ComportamentoAppService : IComportamentoAppService
    {
        IComportamentoRepository _comportamentoRepository;

        public ComportamentoAppService(IComportamentoRepository comportamentoRepository)
        {
            _comportamentoRepository = comportamentoRepository;
        }

        public void SalvarComportamento(Comportamento comportamento)
        {
            _comportamentoRepository.Salvar(comportamento);
        }
    }
}
