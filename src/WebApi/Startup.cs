using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using TesteDBServer.Application.Interfaces;
using TesteDBServer.Application.Services;
using TesteDBServer.Domain.Interfaces;
using TesteDBServer.Domain.Interfaces.Services;
using TesteDBServer.Repository;
using TesteDBServer.Repository.Context.Mysql;
using TesteDBServer.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            //InicializaBancoMysql.CriarAmbiente(Configuration["ConnectionStrings:TesteDBServerContextInicializacao"]);
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<ILancamentoAppService, LancamentoAppService>();
            services.AddScoped<ILancamentoRepository, LancamentoRepository>();
            services.AddScoped<ILancamentoService, LancamentoService>();
            services.AddScoped<IContaCorrenteService, ContaCorrenteService>();
            services.AddScoped<IContaCorrenteAppService, ContaCorrenteAppService>();
            services.AddScoped<IContaCorrenteRepository, ContaCorrenteRepository>();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "TesteViajaNet",
                    Description = "TesteViajaNet",
                });
            });
            var connection = Configuration["ConnectionStrings:TesteDBServerContext"];
            services.AddDbContext<TesteDBServerContext>(options =>
                options.UseMySQL(connection)
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "TesteViajaNet");
            });

        }
    }
}
