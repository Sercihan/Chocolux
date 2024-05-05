using Chocolux.ORM.Entities;
using Microsoft.EntityFrameworkCore;

namespace Chocolux.ORM.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JUDGMENTDAY; Database=ChocoluxDB; Integrated Security=True; TrustServerCertificate=True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Chocolate> Chocolates { get; set; }
    }
}
