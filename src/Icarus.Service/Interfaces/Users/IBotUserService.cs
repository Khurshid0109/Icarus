
using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.BotUser;
using Icarus.Service.DTOs.Users;

namespace Icarus.Service.Interfaces.Users;
public interface IBotUserService
{
    Task<bool> RemoveAsync(long id);
    Task<BotUserForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<BotUserForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<BotUserForResultDto> AddAsync(BotUserForCreationDto dto);
    Task<BotUserForResultDto> RetrieveByPhoneNumber(string phoneNumber);
    Task<BotUserForResultDto> ModifyAsync(long id, BotUserForUpdateDto dto);
}
