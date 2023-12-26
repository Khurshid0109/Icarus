using Icarus.Data.DbContexts;
using Icarus.Domain.Entities;
using Icarus.Data.IRepositories.Users;

namespace Icarus.Data.Repositories.Users
{
    public class UserRepository : Repository<User, long>, IUserRepository
    {
        public UserRepository(IcarusDbContext dbContext) : base(dbContext) { }
    }
}
