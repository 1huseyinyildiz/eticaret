using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.dataaccess.Concrete.EfCoreRepository
{
    public class EfShopContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            optionsBuilder.UseSqlite("Data Source=shopDb");
        }

        //protected override  void OnModelCreating(ModelBuilder modelBuilder)
        //{
        // modelBuilder.Entity<ProductCategory>().HasKey(c=>new {
        //     c.CategoryId,c.ProductId
        // });
        //}

    }
}