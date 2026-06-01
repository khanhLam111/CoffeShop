
using CoffeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeShop.Data
{
    public class CoffeeshopDbContext : DbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options) :
       base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Black Diamond Coffee", Price = 25, ImageUrl = "https://images.unsplash.com/photo-1509042239860-f550ce710b93?w=815", IsTrendingProduct = true },
                new Product { Id = 2, Name = "The Roasted Bean", Price = 35, ImageUrl = "https://images.unsplash.com/photo-1498804103079-a6351b050096?w=815", IsTrendingProduct = true },
                new Product { Id = 3, Name = "Beanery Espresso", Price = 45, ImageUrl = "https://images.unsplash.com/photo-1447933601403-0c6688de566e?w=815", IsTrendingProduct = true },
                new Product { Id = 4, Name = "Americano", Price = 25, ImageUrl = "https://images.unsplash.com/photo-1514432324607-a09d9b4aefdd?w=815", IsTrendingProduct = false },
                new Product { Id = 5, Name = "Mocha", Price = 35, ImageUrl = "https://images.unsplash.com/photo-1572442388796-11668a67e53d?w=815", IsTrendingProduct = false },
                new Product { Id = 6, Name = "French Press", Price = 55, ImageUrl = "https://images.unsplash.com/photo-1510707577719-ae7c14805e3a?w=815", IsTrendingProduct = false }
            );
        }
    }
}
