using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Persistance.Data;

namespace OverengineeredShoppingList.Persistance.Repositories
{
    public sealed class RepositoryManager(AppDbContext appDbContext) : IRepositoryManager, IDisposable
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IProductRepository _productRepository = new ProductRepository(appDbContext);
        private readonly IProductTagRepository _productTagRepository = new ProductTagRepository(appDbContext);
        private readonly IShoppingListRepository _shoppingListRepository = new ShoppingListRepository(appDbContext);
        private readonly ITypeRepository _typeRepository = new TypeRepository(appDbContext);
        private readonly IShoppingListProductRepository _shoppingListProductRepository = new ShoppingListProductRepository(appDbContext);
        private readonly IMetaDataRepository _metaDataRepository = new MetaDataRepository(appDbContext);
        private readonly ITagRepository _tagRepository = new TagRepository(appDbContext);

        public IProductRepository Product => _productRepository;
        public IProductTagRepository ProductTag => _productTagRepository;
        public IShoppingListRepository ShoppingList => _shoppingListRepository;
        public ITypeRepository Type => _typeRepository;
        public IShoppingListProductRepository ShoppingListProduct => _shoppingListProductRepository;
        public IMetaDataRepository MetaData => _metaDataRepository;
        public ITagRepository Tag => _tagRepository;

        public void Save()
        {
            _appDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
