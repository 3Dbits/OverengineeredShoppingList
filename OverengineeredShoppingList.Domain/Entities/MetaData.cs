using System.ComponentModel.DataAnnotations.Schema;

namespace OverengineeredShoppingList.Domain.Entities
{
    public class MetaData
    {
        [Column("MetaDataId")]
        public int Id { get; set; }
        public string PicturePath { get; set; } = default!;
        public string Note { get; set; } = default!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
