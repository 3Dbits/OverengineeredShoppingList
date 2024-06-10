namespace OverengineeredShoppingList.Application.Interfaces.Persistance
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        IShoppingListProductRepository ShoppingListProduct { get; }
        ITagRepository Tag { get; }
        ITypeRepository Type { get; }
        IShoppingListRepository ShoppingList { get; }
        IMetaDataRepository MetaData { get; }
        IProductTagRepository ProductTag { get; }

        void Save();
    }
}
