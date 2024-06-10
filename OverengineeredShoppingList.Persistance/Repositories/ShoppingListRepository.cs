using OverengineeredShoppingList.Domain.Entities;
using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Persistance.Data;

namespace OverengineeredShoppingList.Persistance.Repositories
{
    public class ShoppingListRepository(AppDbContext appDbContext) : RepositoryBase<ShoppingList>(appDbContext), IShoppingListRepository
    {
    }
}
