using System.ComponentModel.DataAnnotations.Schema;

namespace OverengineeredShoppingList.Domain.Entities
{
    public class Tag
    {
        [Column("TagId")]
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<Product> Products { get; set; } = [];
        public ICollection<ProductTag> ProductTypes { get; set; } = [];
    }
}
