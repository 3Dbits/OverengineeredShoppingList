using Microsoft.EntityFrameworkCore;
using OverengineeredShoppingList.Application.Interfaces.Persistance;
using OverengineeredShoppingList.Persistance.Data;
using System.Linq.Expressions;

namespace OverengineeredShoppingList.Persistance.Repositories
{
    public abstract class RepositoryBase<T>(AppDbContext repositoryContext) : IRepositoryBase<T> where T : class
    {
        protected AppDbContext RepositoryContext = repositoryContext;

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
                RepositoryContext.Set<T>()
                    .AsNoTracking() :
                RepositoryContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
                RepositoryContext.Set<T>()
                    .Where(expression)
                    .AsNoTracking() :
                RepositoryContext.Set<T>()
                    .Where(expression);

        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);
        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);
        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
    }
}
