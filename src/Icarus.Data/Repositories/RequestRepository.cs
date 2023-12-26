using Icarus.Data.DbContexts;
using Icarus.Data.IRepositories;
using Icarus.Domain.Entities;

namespace Icarus.Data.Repositories;

public class RequestRepository : Repository<Request, long>, IRequestRepository
{
    public RequestRepository(IcarusDbContext dbContext) : base(dbContext)
    {
    }
}
