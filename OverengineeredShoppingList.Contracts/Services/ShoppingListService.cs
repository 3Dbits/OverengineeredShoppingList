using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Application.Interfaces.Services;

namespace OverengineeredShoppingList.Application.Services
{
    internal sealed class ShoppingListService(IRepositoryManager repository) : IShoppingListService
    {
        private readonly IRepositoryManager _repository = repository;

    }
}
