using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;

namespace TesteViajaNet.Repository.RabbitMQ
{
    public class ComportamentoRepository : IComportamentoRepository
    {
        private PushQueue<Comportamento> _pushQueue;

        public ComportamentoRepository()
        {
            _pushQueue = new PushQueue<Comportamento>();
        }

        public void Salvar(Comportamento comportamento)
        {
            _pushQueue.PushMessage(comportamento, "Comportamento");
        }
    }
}
