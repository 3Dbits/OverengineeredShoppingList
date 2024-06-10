namespace OverengineeredShoppingList.Application.Interfaces.Services
{
    public interface IServiceManager
    {
        IMetaDataService MetaDataService { get; }
        IProductTagService ProductTagService { get; }
        IShoppingListService ShoppingListService { get; }
        IShoppingListProductService ShoppingListProductService { get; }
        IProductService ProductService { get; }
        ITagService TagService { get; }
        ITypeService TypeService { get; }
    }
}
