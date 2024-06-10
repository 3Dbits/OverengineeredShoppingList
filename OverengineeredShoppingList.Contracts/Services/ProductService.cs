using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Application.Interfaces.Services;

namespace OverengineeredShoppingList.Application.Services
{
    internal sealed class ProductService(IRepositoryManager repository) : IProductService
    {
        private readonly IRepositoryManager _repository = repository;

    }
}
