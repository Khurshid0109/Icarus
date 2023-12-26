using Icarus.Data.DbContexts;
using Icarus.Data.IRepositories;
using Icarus.Domain.Entities;

namespace Icarus.Data.Repositories;

public class DepartmentResponseRepository : Repository<DepartmentResponse,long>,IDepartmentResponseReposiroty
{
    public DepartmentResponseRepository(IcarusDbContext DbContext) : base(DbContext)
    {
        
    }
}
