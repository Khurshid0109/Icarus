using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.Categories;

namespace Icarus.Service.Interfaces.Categories;

public interface ICategoryService
{
    Task<bool> RemoveAsync(long id);
    Task<CategoryForResultDto> RetrieveByIdAsync(long id);
    Task<CategoryForResultDto> CreateAsync(CategoryForCreationDto dto);
    Task<CategoryForResultDto> ModifyAsync(long id, CategoryForUpdateDto dto);
    Task<IEnumerable<CategoryForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
