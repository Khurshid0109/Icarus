using AutoMapper;
using Icarus.Domain.Enums;
using Icarus.Domain.Entities;
using Icarus.Data.IRepositories;
using Icarus.Service.Exceptions;
using Icarus.Domain.Configurations;
using Microsoft.EntityFrameworkCore;
using Icarus.Service.Commons.Extensions;
using Icarus.Service.DTOs.DepartmentResponses;
using Icarus.Service.Interfaces.DepartmentResponses;

namespace Icarus.Service.Services.DepartmentResponses;

public class DepartmentResponseService : IDepartmentResponseService
{
    private readonly IMapper _mapper;
    private readonly IRequestRepository _requestRepository;
    private readonly IDepartmentRepository _departmentRepository;
    private readonly IDepartmentResponseReposiroty _responseService;

    public DepartmentResponseService(
        IMapper mapper,
        IRequestRepository requestRepository,
        IDepartmentResponseReposiroty responseService,
        IDepartmentRepository departmentRepository)
    {
        _mapper = mapper;
        _responseService = responseService;
        _requestRepository = requestRepository;
        _departmentRepository = departmentRepository;
    }

    public async Task<DResponseForResultDto> CreateAsync(DResponseForCreationDto dto)
    {
        var request = await _requestRepository.SelectAll()
            .Where(r => r.Id == dto.RequestId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (request is null)
            throw new IcarusException(404, "Request is not found");

        var department = await _departmentRepository.SelectAll()
            .Where(d => d.Id == dto.DepartmentId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (department is null)
            throw new IcarusException(404, "Department is not found");


        var mapped = _mapper.Map<DepartmentResponse>(dto);
        mapped.CreatedAt = DateTime.UtcNow;

        var result = await _responseService.InsertAsync(mapped);
        await _responseService.SaveAsync();

        request.Status = Status.Answered;
        await _requestRepository.UpdateAsync(request);
        await _requestRepository.SaveAsync();

        return _mapper.Map<DResponseForResultDto>(result);
    }

    public async Task<DResponseForResultDto> ModifyAsync(long id, DResponseForUpdateDto dto)
    {
        var request = await _requestRepository.SelectAll()
            .Where(r => r.Id == dto.RequestId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (request is null)
            throw new IcarusException(404, "Request is not found");

        var department = await _departmentRepository.SelectAll()
            .Where(d => d.Id == dto.DepartmentId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (department is null)
            throw new IcarusException(404, "Department is not found");

        var departmentResponse = await _responseService.SelectAll()
            .Where(dr => dr.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (departmentResponse is not null)
            throw new IcarusException(404, "Department Response is not found");

        var mapped = _mapper.Map(dto, departmentResponse);
        mapped.UpdatedAt = DateTime.UtcNow;
        var result = await _responseService.UpdateAsync(mapped);
        await _responseService.SaveAsync();

        return _mapper.Map<DResponseForResultDto>(result);

    }

    public async Task<bool> RemoveAsync(long id)
    {
        var departmentResponse = await _responseService.SelectAll()
            .Where(dr => dr.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (departmentResponse is null)
            throw new IcarusException(404, "Department Response is not found");

        var result = await _responseService.DeleteAsync(id);
        await _responseService.SaveAsync();

        return result;
    }

    public async Task<IEnumerable<DResponseForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var departmentResponse = await _responseService.SelectAll()
            .Include(dr => dr.Request)
            .ThenInclude(r => r.FromWho)
            .Include(dr => dr.Request)
            .ThenInclude(r => r.WhichDepartment)
            .ThenInclude(d => d.Requests)
            .AsNoTracking()
            .ToPagedList<DepartmentResponse, long>(@params)
            .ToListAsync();

        return _mapper.Map<IEnumerable<DResponseForResultDto>>(departmentResponse);
    }

    public async Task<DResponseForResultDto> RetrieveByIdAsync(long id)
    {
        var departmentResponse = await _responseService.SelectAll()
            .Where(dr => dr.Id == id)
            .Include(dr => dr.Request)
            .ThenInclude(r => r.FromWho)
            .Include(dr => dr.Request)
            .ThenInclude(r => r.WhichDepartment)
            .ThenInclude(d => d.Asset)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (departmentResponse is null)
            throw new IcarusException(404, "Department Response is not found");

        return this._mapper.Map<DResponseForResultDto>(departmentResponse);
    }
}
