using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.DepartmentCategories;

namespace Icarus.Service.Interfaces.DepartmentCategories;

public interface IDepartmentCategoryService
{
    Task<bool> RemoveAsync(long id);
    Task<DepartmentCategoryForResultDto> RetrieveByIdAsync(long id);
    Task<DepartmentCategoryForResultDto> CreateAsync(DepartmentCategoryForCreationDto dto);
    Task<IEnumerable<DepartmentCategoryForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<DepartmentCategoryForResultDto> ModifyAsync(long id, DepartmentCategoryForUpdateDto dto);
}
