using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OverengineeredShoppingList.Domain.Entities;
using Type = OverengineeredShoppingList.Domain.Entities.Type;

namespace OverengineeredShoppingList.Persistance.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
            (
            new Product
            {
                Id = 1,
                Name = "Milk",
                CreatedOn = DateTime.Now,
                LastModifiedOn = DateTime.Now,
            },
            new Product
            {
                Id = 2,
                Name = "Apple",
                CreatedOn = DateTime.Now,
                LastModifiedOn = DateTime.Now,
            }
            );
        }
    }
}
