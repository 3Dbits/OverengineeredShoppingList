using System.ComponentModel.DataAnnotations.Schema;

namespace OverengineeredShoppingList.Domain.Entities
{
    public class Product
    {
        [Column("ProductId")]
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public Type? Type { get; set; }
        public MetaData? MetaData { get; set; }
        public ICollection<ShoppingList> ShoppingLists { get; set; } = [];
        public ICollection<ShoppingListProduct> ShoppingListProducts { get; set; } = [];
        public ICollection<Tag> Tags { get; set; } = [];
        public ICollection<ProductTag> ProductTags { get; set; } = [];
    }
}
