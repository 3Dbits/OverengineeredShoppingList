using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Domain.Entities;
using OverengineeredShoppingList.Persistance.Data;

namespace OverengineeredShoppingList.Persistance.Repositories
{
    public class MetaDataRepository(AppDbContext appDbContext) : RepositoryBase<MetaData>(appDbContext), IMetaDataRepository
    {
    }
}
