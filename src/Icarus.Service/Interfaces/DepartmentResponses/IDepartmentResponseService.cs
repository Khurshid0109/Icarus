using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.DepartmentResponses;

namespace Icarus.Service.Interfaces.DepartmentResponses;

public interface IDepartmentResponseService
{
    Task<bool> RemoveAsync(long id);
    Task<DResponseForResultDto> RetrieveByIdAsync(long id);
    Task<DResponseForResultDto> CreateAsync(DResponseForCreationDto dto);
    Task<DResponseForResultDto> ModifyAsync(long id, DResponseForUpdateDto dto);
    Task<IEnumerable<DResponseForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
