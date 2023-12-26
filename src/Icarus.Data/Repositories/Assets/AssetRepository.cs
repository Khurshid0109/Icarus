using Icarus.Data.DbContexts;
using Icarus.Data.IRepositories.Assets;
using Icarus.Domain.Entities;

namespace Icarus.Data.Repositories.Assets;

public class AssetRepository : Repository<Asset,long> , IAssetRepository
{
    public AssetRepository(IcarusDbContext dbContext) : base(dbContext)
    {
        
    }
}
