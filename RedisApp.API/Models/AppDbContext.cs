using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace RedisApp.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

                new Product()
                {
                    Id = 1,
                    Name = "Water",
                    Price = 5
                },

                new Product()
                {
                    Id = 2,
                    Name = "Apple",
                    Price = 7
                },
                new Product()
                {
                    Id = 3,
                    Name = "Milk",
                    Price = 15
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
