using Icarus.Data.DbContexts;
using Icarus.Domain.Entities;
using Icarus.Data.IRepositories.Users;

namespace Icarus.Data.Repositories.Users;
public class BotUserRepository : Repository<BotUser, long>, IBotUserRepository
{
    public BotUserRepository(IcarusDbContext dbContext) : base(dbContext)
    {
    }
}
