using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteViajaNet.Repository.RabbitMQ
{
    public class PushQueue<T>
    {
        private IConnection _conn;

        public PushQueue()
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@192.168.52.134:5672");

            //_conn = factory.CreateConnection();
        }

        public void PushMessage(T message, string queueName)
        {
            var model = _conn.CreateModel();

            model.QueueDeclare(queueName, false, false, false, null);

            IBasicProperties basicProperties = model.CreateBasicProperties();
            model.BasicPublish("", queueName, false, basicProperties, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message)));
        }
    }
}
