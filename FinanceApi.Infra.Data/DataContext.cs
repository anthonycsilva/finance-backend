using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApi.Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceApi.Infra.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}