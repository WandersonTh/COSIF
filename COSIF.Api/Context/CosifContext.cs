using COSIF.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace COSIF.Api.Context
{
    public class CosifContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Produto_Cosif> Produto_Cosif { get; set; }
        public DbSet<Movimento_Manual> Movimento_Manual { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-KI594OQ\SQLEXPRESS;Database=DBSQE001;Trusted_Connection=True");
        }
    }
}
