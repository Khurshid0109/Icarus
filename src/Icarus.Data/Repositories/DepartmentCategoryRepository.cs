using Icarus.Data.DbContexts;
using Icarus.Data.IRepositories;
using Icarus.Domain.Entities;

namespace Icarus.Data.Repositories;

public class DepartmentCategoryRepository : Repository<DepartmentCategory,long>,IDepartmentCategoryRepository
{
    public DepartmentCategoryRepository(IcarusDbContext DbContext) : base(DbContext)
    {
        
    }
}
