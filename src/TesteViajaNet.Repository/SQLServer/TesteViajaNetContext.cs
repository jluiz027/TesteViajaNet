using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TesteViajaNet.Domain.Entities;

namespace TesteViajaNet.Repository.Context.SqlServer
{
    public class TesteViajaNetContext : DbContext
    {
        public DbSet<Pedido> pedido { get; set; }
        public DbSet<Comportamento> comportamento { get; set; }

        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        //public TesteViajaNetContext(IConfiguration configuration)
        //{
        //    //_connectionString = _configuration.GetSection("ConnectionStrings").GetSection("TesteDBServerContext").Value;
        //    _connectionString = _configuration.GetSection("ConnectionStrings").GetSection("TesteDBServerContext").Value;

        //}

        public TesteViajaNetContext()
        {
            //_connectionString = _configuration.GetSection("ConnectionStrings").GetSection("TesteDBServerContext").Value;
            //_connectionString = _configuration.GetSection("ConnectionStrings").GetSection("TesteDBServerContext").Value;
            _connectionString = "Server=192.168.52.134;Database=TesteViajaNet;Uid=sa;Pwd=Amadeus@*0";

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(_connectionString);
    }
}
