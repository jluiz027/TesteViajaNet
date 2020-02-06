using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using System;
using TesteViajaNet.Application.Interfaces;
using TesteViajaNet.Application.Services;
using TesteViajaNet.Domain.Interfaces;
using TesteViajaNet.Repository;
using TesteViajaNet.Repository.Couchbase;

namespace TesteViajaNet.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            IServiceCollection services = new ServiceCollection();
            //services.AddSingleton<IConfiguration>(configuration);
            services.AddScoped<Startup>();
            
            services.AddScoped<IComportamentoAppService, ComportamentoAppService>();
            services.AddScoped<IComportamentoRepository, ComportamentoDuplaPersistenciaRepository>();
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            //Iniciando serviço
            serviceProvider.GetService<Startup>().Iniciar();

        }
    }
}
