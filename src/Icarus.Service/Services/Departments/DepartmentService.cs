using AutoMapper;
using Icarus.Data.IRepositories;
using Icarus.Domain.Configurations;
using Icarus.Domain.Entities;
using Icarus.Service.Commons.Extensions;
using Icarus.Service.DTOs.Departments;
using Icarus.Service.Exceptions;
using Icarus.Service.Interfaces.Departments;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Service.Services.Departments;

public class DepartmentService : IDepartmentService
{
    private readonly IMapper _mapper;
    private readonly IDepartmentRepository _repository;

    public DepartmentService(IMapper mapper, IDepartmentRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<DepartmentForResultDto> CreateAsync(DepartmentForCreationDto dto)
    {
        var department = await _repository.SelectAll()
            .Where(d => d.Rating == dto.Rating)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (department is not null)
            throw new IcarusException(404,"Department is already exists");

        var mapped = _mapper.Map<Department>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        var result = await _repository.InsertAsync(mapped);
        await _repository.SaveAsync();

        return _mapper.Map<DepartmentForResultDto>(result);
    }

    public async Task<DepartmentForResultDto> ModifyAsync(long id, DepartmentForUpdateDto dto)
    {
        var department = await _repository.SelectAll()
            .Where (d => d.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (department is null)
            throw new IcarusException(404, "Department is not found");

        var mapped = _mapper.Map(dto, department);
        mapped.UpdatedAt = DateTime.UtcNow;
        await _repository.UpdateAsync(mapped);
        await _repository.SaveAsync();

        return _mapper.Map<DepartmentForResultDto>(mapped);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var department = await _repository.SelectAll()
            .Where(d => d.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (department is null)
            throw new IcarusException(404, "Department is not found");
        var result = await _repository.DeleteAsync(id);
        await _repository.SaveAsync();

        return result;
    }

    public async Task<IEnumerable<DepartmentForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var department = await _repository.SelectAll()
            .Include(d => d.Asset)  
            .AsNoTracking()
            .ToPagedList<Department, long>(@params)
            .ToListAsync();
        
        return _mapper.Map<IEnumerable<DepartmentForResultDto>>(department);
    }

    public async Task<DepartmentForResultDto> RetrieveByIdAsync(long id)
    {
        var department = await _repository.SelectAll()
            .Where(d => d.Id == id)
            .Include(d => d.Asset)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (department is null)
            throw new IcarusException(404, "Department is not found");

        return _mapper.Map<DepartmentForResultDto>(department);
    }
}
