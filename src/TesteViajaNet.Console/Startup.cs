using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;
using TesteViajaNet.Domain.Interfaces;

namespace TesteViajaNet.Console
{
    class Startup
    {
        private IComportamentoRepository _comportamentoRepository;
        public Startup(IComportamentoRepository comportamentoRepository)
        {
            _comportamentoRepository = comportamentoRepository;
        }
        public void Iniciar()
        {
            var queueName = "Comportamento";

            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@192.168.52.134:5672")
            };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: queueName,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

                var consumer = new EventingBasicConsumer(channel);

                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    System.Console.WriteLine(" [x] Received {0}", message);
                    var comportamento = JsonConvert.DeserializeObject<Comportamento>(message);

                    _comportamentoRepository.Salvar(comportamento);
                };

                channel.BasicConsume(queue: queueName,
                                     autoAck: true,
                                     consumer: consumer);

                
                System.Console.WriteLine("Consumer is now listening. Press [enter] to exit.");
                System.Console.ReadLine();
            }
        }
    }
}
