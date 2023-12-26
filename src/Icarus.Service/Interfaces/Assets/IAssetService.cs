using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.Assets;

namespace Icarus.Service.Interfaces.Assets;

public interface IAssetService
{
    Task<bool> RemoveAsync(long id);
    Task<AssetForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<AssetForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<AssetForResultDto> CreateAsync(AssetForCreationDto dto);
    Task<AssetForResultDto> ModifyAsync(long id, AssetForUpdateDto dto);
}
