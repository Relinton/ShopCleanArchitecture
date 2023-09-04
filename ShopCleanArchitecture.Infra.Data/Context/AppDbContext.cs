using Microsoft.EntityFrameworkCore;
using ShopCleanArchitecture.Domain.Entities;

namespace ShopCleanArchitecture.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }
    }
}
