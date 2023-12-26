using AutoMapper;
using Icarus.Domain.Entities;
using Icarus.Data.IRepositories;
using Icarus.Service.Exceptions;
using Icarus.Service.DTOs.Requests;
using Icarus.Domain.Configurations;
using Microsoft.EntityFrameworkCore;
using Icarus.Data.IRepositories.Users;
using Icarus.Service.Commons.Extensions;
using Icarus.Service.Interfaces.Requests;
using Icarus.Domain.Enums;

namespace Icarus.Service.Services.Requests;

public class RequestService : IRequestService
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;
    private readonly IRequestRepository _requestRepository;
    private readonly IDepartmentRepository _departmentRepository;
    public RequestService(IRequestRepository requestRepository, IMapper mapper, IUserRepository userRepository, IDepartmentRepository departmentRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
        _requestRepository = requestRepository;
        _departmentRepository = departmentRepository;
    }

    public async Task<RequestForResultDto> CreateAsync(RequestForCreationDto dto)
    {
        var user = await _userRepository.SelectAll()
            .Where(c => c.Id == dto.UserId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (user is null)
            throw new IcarusException(404, "User is not found!");

        var request = await _requestRepository.SelectAll()
            .Where(r => r.UserId == dto.UserId)
            .Where(r => r.Status == Status.Pending)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (request is not null)
            throw new IcarusException(405, "You can not do it,because you have already unreaded request");

        var department = await _departmentRepository.SelectAll()
            .Where(c => c.Id == dto.DepartmentId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (department is null)
            throw new IcarusException(404, "Department is not found!");

        var mappedRequest = _mapper.Map<Request>(dto);
        mappedRequest.CreatedAt = DateTime.UtcNow;

        var result = await _requestRepository.InsertAsync(mappedRequest);
        await _requestRepository.SaveAsync();

        return this._mapper.Map<RequestForResultDto>(result);
    }

    public async Task<RequestForResultDto> ModifyAsync(long id, RequestForUpdateDto dto)
    {
        var request = await _requestRepository.SelectAll()
            .Where(r => r.Id == id)
            .FirstOrDefaultAsync();

        if (request is null)
            throw new IcarusException(404, "Request is not found !");

        if (request.Status == Status.Answered)
            throw new IcarusException(405, "You can not change it");

        var mappedRequest = _mapper.Map<Request>(dto);
        mappedRequest.UpdatedAt = DateTime.UtcNow;

        var result = await _requestRepository.UpdateAsync(mappedRequest);
        await _requestRepository.SaveAsync();

        return this._mapper.Map<RequestForResultDto>(result);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var request = await _requestRepository.SelectAll()
            .Where(r => r.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (request is null)
            throw new IcarusException(404, "Request is not found");

        var result = await _requestRepository.DeleteAsync(id);
        await _requestRepository.SaveAsync();

        return result;
    }

    public async Task<IEnumerable<RequestForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var request = await _requestRepository.SelectAll()
            .Include(u => u.FromWho)
            .Include(d => d.WhichDepartment)
            .ThenInclude(a => a.Asset)
            .AsNoTracking()
            .ToPagedList<Request, long>(@params)
            .ToListAsync();

        return _mapper.Map<IEnumerable<RequestForResultDto>>(request);
    }

    public async Task<RequestForResultDto> RetrieveByIdAsync(long id)
    {
        var request = await this._requestRepository.SelectAll()
                .Where(c => c.Id == id)
                .Include(u => u.FromWho)
                .Include(d => d.WhichDepartment)
                .ThenInclude(a => a.Asset)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (request is null)
            throw new IcarusException(404, "Request is not found");

        return this._mapper.Map<RequestForResultDto>(request);
    }
}
