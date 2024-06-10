using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Application.Interfaces.Services;

namespace OverengineeredShoppingList.Application.Services
{
    internal sealed class TypeService(IRepositoryManager repository) : ITypeService
    {
        private readonly IRepositoryManager _repository = repository;

}
}
