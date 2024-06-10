using OverengineeredShoppingList.Domain.Entities;
using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Persistance.Data;

namespace OverengineeredShoppingList.Persistance.Repositories
{
    public class TagRepository(AppDbContext appDbContext) : RepositoryBase<Tag>(appDbContext), ITagRepository
    {
    }
}
