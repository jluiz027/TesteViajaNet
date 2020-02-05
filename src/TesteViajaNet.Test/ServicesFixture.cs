using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TesteDBServer.Application.Interfaces;
using TesteDBServer.Application.Services;
using TesteDBServer.Domain.Interfaces;
using TesteDBServer.Domain.Interfaces.Services;
using TesteDBServer.Domain.Services;
using TesteDBServer.Repository;
using TesteDBServer.Repository.Context.Mysql;

namespace TesteDBServer.Test
{
    public class ServicesFixture
    {
        public ServicesFixture()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var Configuration = builder.Build();

            var connection = Configuration["ConnectionStrings:TesteDBServerContext"];

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddScoped<ILancamentoAppService, LancamentoAppService>();
            serviceCollection.AddScoped<IContaCorrenteAppService, ContaCorrenteAppService>();
            serviceCollection.AddScoped<ILancamentoRepository, LancamentoRepository>();
            serviceCollection.AddScoped<ILancamentoService, LancamentoService>();
            serviceCollection.AddScoped<IContaCorrenteService, ContaCorrenteService>();
            serviceCollection.AddScoped<IContaCorrenteRepository, ContaCorrenteRepository>();
            serviceCollection
                .AddDbContext<TesteDBServerContext>(options => options.UseMySQL(connection),
                    ServiceLifetime.Transient);

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public ServiceProvider ServiceProvider { get; private set; }
    }
}
