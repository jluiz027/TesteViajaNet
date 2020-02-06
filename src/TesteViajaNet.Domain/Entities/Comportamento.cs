using System;
using System.Collections.Generic;
using System.Text;

namespace TesteViajaNet.Domain.Entities
{
    public class Comportamento
    {
        public string Id { get; set; }
        public string IP { get; set; }
        public string NomeDaPagina { get; set; }
        public string Browser { get; set; }
    }
}
