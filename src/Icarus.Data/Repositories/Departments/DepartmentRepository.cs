using Icarus.Data.DbContexts;
using Icarus.Data.IRepositories;
using Icarus.Domain.Entities;

namespace Icarus.Data.Repositories.Departments;

public class DepartmentRepository : Repository<Department,long>,IDepartmentRepository
{
    public DepartmentRepository(IcarusDbContext DbContext) : base(DbContext)
    {
        
    }
}
