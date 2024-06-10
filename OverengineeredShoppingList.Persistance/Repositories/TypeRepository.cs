using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Persistance.Data;
using Type = OverengineeredShoppingList.Domain.Entities.Type;

namespace OverengineeredShoppingList.Persistance.Repositories
{
    public class TypeRepository(AppDbContext appDbContext) : RepositoryBase<Type>(appDbContext), ITypeRepository
    {
    }
}
