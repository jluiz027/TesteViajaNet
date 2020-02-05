using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Domain.Entities;

namespace TesteDBServer.Repository.Context.SqlServer
{
    public class TesteDBServerContext : DbContext
    {
        public DbSet<Lancamento> lancamentos { get; set; }
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public TesteDBServerContext(IConfiguration configuration)
        {
            _connectionString = _configuration.GetSection("ConnectionStrings").GetSection("TesteDBServerContext").Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(_connectionString);
    }
}
