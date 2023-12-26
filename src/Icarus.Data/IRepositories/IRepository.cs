using Icarus.Domain.Commons;

namespace Icarus.Data.IRepositories;
public interface IRepository<TEntity,TKey> where TEntity : Auditable<TKey>
{
    Task<TEntity> InsertAsync(TEntity entity);
    Task<bool> InsertManyAsync(IEnumerable<TEntity> entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    IQueryable<TEntity> SelectAll();
    Task<TEntity> SelectByIdAsync(TKey id);
    Task<bool> DeleteAsync(TKey id);
    bool DeleteMany(ICollection<TKey> id);
    Task SaveAsync();
}
