using AvanadeHealth.Models;
using Microsoft.EntityFrameworkCore;

namespace AvanadeHealth.Repository.Context
{
    public class DatabaseContext: DbContext
    {

            public DbSet<Agendamento> AGENDAMENTO { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                    optionsBuilder.UseSqlServer(config.GetConnectionString("AvanadeHealth"));
                }
            }

            protected override void OnModelCreating(ModelBuilder modelbuilder)
            {

            }
        }
    }
}
