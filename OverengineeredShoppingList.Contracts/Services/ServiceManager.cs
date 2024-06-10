using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Application.Interfaces.Services;

namespace OverengineeredShoppingList.Application.Services
{
    public sealed class ServiceManager(IRepositoryManager repositoryManager) : IServiceManager
    {
        private readonly IProductService _productService = new ProductService(repositoryManager);
        private readonly IProductTagService _productTagService = new ProductTagService(repositoryManager);
        private readonly IShoppingListService _shoppingListService = new ShoppingListService(repositoryManager);
        private readonly ITypeService _typeService = new TypeService(repositoryManager);
        private readonly IShoppingListProductService _shoppingListProductService = new ShoppingListProductService(repositoryManager);
        private readonly IMetaDataService _metaDataService = new MetaDataService(repositoryManager);
        private readonly ITagService _tagService = new TagService(repositoryManager);

        public IProductService ProductService => _productService;
        public IProductTagService ProductTagService => _productTagService;
        public IShoppingListService ShoppingListService => _shoppingListService;
        public ITypeService TypeService => _typeService;
        public IShoppingListProductService ShoppingListProductService => _shoppingListProductService;
        public IMetaDataService MetaDataService => _metaDataService;
        public ITagService TagService => _tagService;
    }
}
