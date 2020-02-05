using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Application.Interfaces;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;

namespace TesteViajaNet.Application.Services
{
    class ComportamentoAppService : IComportamentoAppService
    {
        IComportamentoRepository _comportamentoRepository;

        public ComportamentoAppService(IComportamentoRepository comportamentoRepository)
        {
            _comportamentoRepository = comportamentoRepository;
        }

        public void SalvarComportamento(Comportamento comportamento)
        {
            throw new NotImplementedException();
        }
    }
}
