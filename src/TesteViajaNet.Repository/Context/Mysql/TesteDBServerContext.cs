using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TesteDBServer.Domain.Entities;
using MySql.Data.EntityFrameworkCore;

namespace TesteDBServer.Repository.Context.Mysql
{
    public class TesteDBServerContext : DbContext
    {
        public DbSet<Lancamento> Lancamento { get; set; }
        public DbSet<ContaCorrente> ContaCorrente { get; set; }
        private readonly string _connectionString;
        private IDbContextTransaction transaction;
        public TesteDBServerContext(DbContextOptions<TesteDBServerContext> options):base(options)
        {
            //_connectionString = configuration.GetSection("ConnectionStrings").GetSection("TesteDBServerContext").Value;
        }

        internal void ConluirTransacao()
        {
            transaction.Commit();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer(_connectionString);

        internal void IniciarTransacao()
        {
            transaction = this.Database.BeginTransaction();
        }

        internal void ReverterTransacao()
        {
            transaction.Rollback();
        }
    }
}
