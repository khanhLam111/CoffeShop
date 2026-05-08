using coffeeshop.Models;
using Microsoft.EntityFrameworkCore;
namespace coffeeshop.Data
{
    public class CoffeeshopDbContext : DbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options) :
       base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "America", Price = 25, ImageUrl = "https://link-anh-1.jpg" },
                new Product { Id = 2, Name = "Vietnam", Price = 20, ImageUrl = "https://link-anh-2.jpg" },
                new Product { Id = 3, Name = "United Kingdom", Price = 15, ImageUrl = "https://link-anh-3.jpg" }
            // Bạn có thể thêm nhiều sản phẩm khác ở đây...
            );
        }
    }
}
