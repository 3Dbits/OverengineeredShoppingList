namespace OverengineeredShoppingList.Domain.Entities
{
    public class ShoppingListProduct
    {
        public int ShoppingListId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
