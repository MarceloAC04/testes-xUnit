using api_teste.Domains;
using Microsoft.EntityFrameworkCore;

namespace api_teste.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE13-SALA19; Database=TesteApi_Manha; User Id=sa; Pwd=Senai@134; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
