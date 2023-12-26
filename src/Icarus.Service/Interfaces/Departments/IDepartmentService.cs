using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.Departments;

namespace Icarus.Service.Interfaces.Departments;

public interface IDepartmentService
{
    Task<bool> RemoveAsync(long id);
    Task<DepartmentForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<DepartmentForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<DepartmentForResultDto> CreateAsync(DepartmentForCreationDto dto);
    Task<DepartmentForResultDto> ModifyAsync(long id, DepartmentForUpdateDto dto);
}
