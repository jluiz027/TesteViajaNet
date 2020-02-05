using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDBServer.Domain.Entities
{
    public class Transferencia
    {
        public string ContaOrigemId { get; set; }
        public string ContaDestinoId { get; set; }
        public Decimal Valor { get; set; }
    }
}
