
using BulkyBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Investing" , DisplayOrder = 1 },
                new Category { Id = 2, Name = "Finance" , DisplayOrder = 2 },
                new Category { Id = 3, Name = "Self-help" , DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Rich Dad Poor Dad",
                    Author = "Robert T. Kiyosaki",
                    Description = "advocates the importance of financial literacy",
                    ISBN = "SER12099",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Intelligent Investor",
                    Author = "Benjamin Graham",
                    Description = "how to successfully use value investing in the stock market",
                    ISBN = "SER12090",
                    ListPrice = 110,
                    Price = 100,
                    Price50 = 95,
                    Price100 = 90,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "How to Win Friends and Influence People",
                    Author = "Dale Carnegie",
                    Description = "Be genuinely interested in other people.",
                    ISBN = "SER12095",
                    ListPrice = 100,
                    Price = 90,
                    Price50 = 80,
                    Price100 = 70,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
        }
    }
}
