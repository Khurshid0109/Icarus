using Icarus.Data.DbContexts;
using Icarus.Data.IRepositories;
using Icarus.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Icarus.Data.Repositories;
public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : Auditable<TKey>
{
    protected readonly IcarusDbContext _dbContext;
    protected readonly DbSet<TEntity> _dbSet;

    public Repository(IcarusDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }
    public async Task<bool> DeleteAsync(TKey id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(e => e.Id.Equals(id));
        _dbSet.Remove(entity);

        return true;
    }

    public bool DeleteMany(ICollection<TKey> ids)
    {
        // Get entities by their keys
        var entitiesToDelete = _dbSet.Where(entity => ids.Contains(entity.Id)).ToList();

        // If there are entities to delete, remove them
        if (entitiesToDelete.Any())
        {
            _dbSet.RemoveRange(entitiesToDelete);
            _dbContext.SaveChanges();
        }

        return true;
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        var entry = await _dbSet.AddAsync(entity);

        return entry.Entity;
    }

    public async Task<bool> InsertManyAsync(IEnumerable<TEntity> entity)
    {
        await _dbSet.AddRangeAsync(entity);
        return true;
    }

    public async Task SaveAsync()
    => await _dbContext.SaveChangesAsync();

    public IQueryable<TEntity> SelectAll()
    => _dbSet;

    public async Task<TEntity> SelectByIdAsync(TKey id)
    => await _dbSet.FirstOrDefaultAsync(e => e.Id.Equals(id));

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var entry = _dbContext.Update(entity);
        return entry.Entity;
    }
}
