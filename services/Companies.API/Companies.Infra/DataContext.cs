using Companies.Domain.Aggregates.Company;
using Companies.Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Companies.Infra
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employee { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfig());
            modelBuilder.ApplyConfiguration(new CompanyHistoryConfig());

        }
    }
}
