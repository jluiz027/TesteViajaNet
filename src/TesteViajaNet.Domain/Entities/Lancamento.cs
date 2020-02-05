using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDBServer.Domain.Entities
{
    public class Lancamento
    {
        public string id { get; set; }
        public TipoLancamento tipoLancamento { get; set; }

        public decimal valor { get; set; }

        public string idContaCorrente { get; set; }

    }
}
