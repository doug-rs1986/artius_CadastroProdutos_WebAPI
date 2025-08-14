using Microsoft.EntityFrameworkCore;
using artius_CadastroProdutos_WebAPI.Models;

namespace artius_CadastroProdutos_WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }
    }
}
