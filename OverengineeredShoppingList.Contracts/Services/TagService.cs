using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Application.Interfaces.Services;

namespace OverengineeredShoppingList.Application.Services
{
    internal class TagService(IRepositoryManager repository) : ITagService
    {
        private readonly IRepositoryManager _repository = repository;

    }
}
