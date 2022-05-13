using System;
using System.Collections.Generic;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;

namespace cadastroClientes.Infrastructure.Database
{
    public class Context : DbContext
    {
        //public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (Environment.GetEnvironmentVariable("DBCONN") != null)
            {
                optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("DBCONN"), npgsqlOptionsAction: options =>
                {
                    options.EnableRetryOnFailure(2, TimeSpan.FromSeconds(5), new List<string>());
                    options.MigrationsHistoryTable("_MigrationHistory", "Cadastro");
                });
            }
            else
            {
                optionsBuilder.UseInMemoryDatabase("CadastroInMemory");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();

            //modelBuilder.ApplyConfiguration(new CustomerMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
