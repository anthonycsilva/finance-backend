using FinanceApi.Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceApi.Infra.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DataContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Finance;User Id=postgres;Password=postgres;");
        }
    }
}