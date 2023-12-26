
using AutoMapper;
using Icarus.Data.IRepositories.Users;
using Icarus.Domain.Configurations;
using Icarus.Domain.Entities;
using Icarus.Service.DTOs.BotUser;
using Icarus.Service.Exceptions;
using Icarus.Service.Interfaces.Users;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Service.Services.Users;
public class BotUserService : IBotUserService
{
    private readonly IMapper _mapper;
    private readonly IBotUserRepository _repository;

    public BotUserService(IBotUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<BotUserForResultDto> AddAsync(BotUserForCreationDto dto)
    {
        var user = await _repository.SelectAll()
             .Where(u => u.TelegramId == dto.TelegramId)
             .AsNoTracking()
             .FirstOrDefaultAsync();

        if (user is not null)
            throw new IcarusException(409, "BotUser already exists");

        var mapped = _mapper.Map<BotUser>(dto);
        mapped.CreatedAt = DateTime.UtcNow;

        var result = await _repository.InsertAsync(mapped);
        await _repository.SaveAsync();

        return _mapper.Map<BotUserForResultDto>(result);
    }

    public Task<BotUserForResultDto> ModifyAsync(long id, BotUserForUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BotUserForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<BotUserForResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<BotUserForResultDto> RetrieveByTelegramIdAsync(long telegramId)
    {
        var user = await _repository.SelectAll()
            .Where(u => u.TelegramId == telegramId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (user is not null)
            throw new IcarusException(409, "BotUser already exists");

        return _mapper.Map<BotUserForResultDto>(user);
    }

    public Task<BotUserForResultDto> RetrieveByPhoneNumber(string phoneNumber)
    {
        throw new NotImplementedException();
    }
}
