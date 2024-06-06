using System.ComponentModel.DataAnnotations.Schema;

namespace OverengineeredShoppingList.Domain.Entities
{
    public class Type
    {
        [Column("TypesId")]
        public int Id { get; set; }
        public required string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
