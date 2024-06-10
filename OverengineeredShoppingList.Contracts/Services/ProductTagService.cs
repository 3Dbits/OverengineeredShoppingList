using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Application.Interfaces.Services;

namespace OverengineeredShoppingList.Application.Services
{
    internal sealed class ProductTagService(IRepositoryManager repository) : IProductTagService
    {
        private readonly IRepositoryManager _repository = repository;

    }
}
