using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OverengineeredShoppingList.Domain.Entities;
using OverengineeredShoppingList.Persistance.Configuration;
using Type = OverengineeredShoppingList.Domain.Entities.Type;

namespace OverengineeredShoppingList.Persistance.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
        public DbSet<MetaData> MetaDatas { get; set; }
        public DbSet<ProductTag> ProductTypes { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<ShoppingListProduct> ShoppingListProducts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(e => e.Type)
                .WithOne(e => e.Product)
                .HasForeignKey<Type>(e => e.ProductId)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .HasOne(e => e.MetaData)
                .WithOne(e => e.Product)
                .HasForeignKey<MetaData>(e => e.ProductId)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Products)
                .UsingEntity<ProductTag>();

            modelBuilder.Entity<ShoppingList>()
                .HasMany(e => e.Products)
                .WithMany(e => e.ShoppingLists)
                .UsingEntity<ShoppingListProduct>(
                    j => j.Property(e => e.CreatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP"));

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
