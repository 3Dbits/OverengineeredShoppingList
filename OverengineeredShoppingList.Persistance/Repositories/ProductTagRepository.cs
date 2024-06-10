using OverengineeredShoppingList.Domain.Entities;
using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Persistance.Data;

namespace OverengineeredShoppingList.Persistance.Repositories
{
    public class ProductTagRepository(AppDbContext appDbContext) : RepositoryBase<ProductTag>(appDbContext), IProductTagRepository
    {
    }
}
