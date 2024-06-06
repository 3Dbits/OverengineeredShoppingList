using System.ComponentModel.DataAnnotations.Schema;

namespace OverengineeredShoppingList.Domain.Entities
{
    public class ShoppingList
    {
        [Column("ShoppingListId")]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public ICollection<Product> Products { get; set; } = [];
        public ICollection<ShoppingListProduct> ShoppingListProducts { get; set; } = [];
    }
}
