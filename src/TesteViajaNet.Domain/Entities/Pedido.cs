using System;
using System.Collections.Generic;
using System.Text;

namespace TesteViajaNet.Domain.Entities
{
    public class Pedido
    {
        public string id { get; set; }
        public DateTime dataRealizacao { get; set; }
        public int quantidade { get; set; }
        public string idProduto { get; set; }
    }
}
