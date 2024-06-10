using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Application.Interfaces.Services;

namespace OverengineeredShoppingList.Application.Services
{
    internal sealed class MetaDataService(IRepositoryManager repository) : IMetaDataService
    {
        private readonly IRepositoryManager _repository = repository;
        private readonly ILogger _logger;

    }
}
