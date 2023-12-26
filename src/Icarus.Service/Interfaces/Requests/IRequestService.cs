using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.Requests;

namespace Icarus.Service.Interfaces.Requests;

public interface IRequestService
{
    Task<bool> RemoveAsync(long id);
    Task<RequestForResultDto> RetrieveByIdAsync(long id);
    Task<RequestForResultDto> CreateAsync(RequestForCreationDto dto);
    Task<RequestForResultDto> ModifyAsync(long id, RequestForUpdateDto dto);
    Task<IEnumerable<RequestForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
