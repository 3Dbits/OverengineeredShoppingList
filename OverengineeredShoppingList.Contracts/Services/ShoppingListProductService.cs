using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Application.Interfaces.Services;

namespace OverengineeredShoppingList.Application.Services
{
    internal sealed class ShoppingListProductService(IRepositoryManager repository) : IShoppingListProductService
    {
        private readonly IRepositoryManager _repository = repository;

    }
}
