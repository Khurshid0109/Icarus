using Icarus.Data.DbContexts;
using Icarus.Data.IRepositories;
using Icarus.Domain.Entities;

namespace Icarus.Data.Repositories;

public class CategoryRepository : Repository<Category, long>, ICategoryRepository
{
    public CategoryRepository(IcarusDbContext DbContext) : base(DbContext)
    {
    }
}
