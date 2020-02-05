using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TesteDBServer.Domain.Entities
{
    public enum TipoLancamento
    {
        [Description("Credito")] Credito = 1,
        [Description("Europ")] Debito = 2,
    }
}
