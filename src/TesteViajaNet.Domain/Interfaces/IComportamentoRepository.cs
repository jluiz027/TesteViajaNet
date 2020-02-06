using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;

namespace TesteViajaNet.Domain.Interfaces
{
    public interface IComportamentoRepository
    {
        void Salvar(Comportamento comportamento);
    }
}
