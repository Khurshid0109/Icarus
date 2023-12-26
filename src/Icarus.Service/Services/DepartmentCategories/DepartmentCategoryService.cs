using AutoMapper;
using Icarus.Domain.Entities;
using Icarus.Data.IRepositories;
using Icarus.Service.Exceptions;
using Microsoft.EntityFrameworkCore;
using Icarus.Service.DTOs.DepartmentCategories;
using Icarus.Service.Interfaces.DepartmentCategories;
using Icarus.Domain.Configurations;
using Icarus.Service.Commons.Extensions;

namespace Icarus.Service.Services.DepartmentCategories;

public class DepartmentCategoryService : IDepartmentCategoryService
{
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IDepartmentRepository _departmentRepository;
    private readonly IDepartmentCategoryRepository _departmentCategoryRepository;
    public DepartmentCategoryService(IMapper mapper,
        ICategoryRepository categoryRepository,
        IDepartmentCategoryRepository departmentCategoryRepository,
        IDepartmentRepository departmentRepository)
    {
        _mapper = mapper;
        _categoryRepository = categoryRepository;
        _departmentRepository = departmentRepository;
        _departmentCategoryRepository = departmentCategoryRepository;
    }
    public async Task<DepartmentCategoryForResultDto> CreateAsync(DepartmentCategoryForCreationDto dto)
    {
        var department = await _departmentRepository.SelectAll()
            .Where(d => d.Id == dto.DepartmentId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (department is null)
            throw new IcarusException(404, "Department is not found");

        var category = await _categoryRepository.SelectAll()
            .Where(c => c.Id == dto.CategoryId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (category is null)
            throw new IcarusException(404, "Category is not found");

        var mapped = _mapper.Map<DepartmentCategory>(dto);
        mapped.CreatedAt = DateTime.UtcNow;

        var result = await _departmentCategoryRepository.InsertAsync(mapped);
        await _departmentCategoryRepository.SaveAsync();

        return _mapper.Map<DepartmentCategoryForResultDto>(result);
    }

    public async Task<DepartmentCategoryForResultDto> ModifyAsync(long id, DepartmentCategoryForUpdateDto dto)
    {
        var category = await _categoryRepository.SelectAll()
            .Where(c => c.Id == dto.CategoryId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (category is null)
            throw new IcarusException(404, "Category is not found");

        var department = await _departmentRepository.SelectAll()
            .Where(d => d.Id == dto.DepartmentId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (department is null)
            throw new IcarusException(404, "Department is not found");

        var departmentCategory = await _departmentCategoryRepository.SelectAll()
            .Where(dc => dc.Id == id)
            .FirstOrDefaultAsync();

        if (departmentCategory is null)
            throw new IcarusException(404, "Department cAtegory is not found");

        var mapped = _mapper.Map(dto, departmentCategory);
        mapped.UpdatedAt = DateTime.UtcNow;
        var result = await _departmentCategoryRepository.UpdateAsync(mapped);
        await _departmentCategoryRepository.SaveAsync();

        return _mapper.Map<DepartmentCategoryForResultDto>(result);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var departmentCategory = await _departmentCategoryRepository.SelectAll()
            .Where (dc => dc.Id == (int)id)
            .FirstOrDefaultAsync ();

        if (departmentCategory is null)
            throw new IcarusException(404, "Department Category is not found");

        var result = await _departmentCategoryRepository.DeleteAsync((int)id);
        await _departmentCategoryRepository.SaveAsync();

        return result;
    }

    public async Task<IEnumerable<DepartmentCategoryForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var departmentCategory = await _departmentCategoryRepository.SelectAll()
                .Include(c => c.Category)
                .Include(d => d.Department)
                .ThenInclude(a => a.Asset)
                .AsNoTracking()
                .ToPagedList<DepartmentCategory, long>(@params)
                .ToListAsync();

        return _mapper.Map<IEnumerable<DepartmentCategoryForResultDto>>(departmentCategory);
    }

    public async Task<DepartmentCategoryForResultDto> RetrieveByIdAsync(long id)
    {
        var departmentCategory = await this._departmentCategoryRepository.SelectAll()
                .Where(dc => dc.Id == id)
                .Include(c => c.Category)
                .Include(d => d.Department)
                .ThenInclude(a => a.Asset)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (departmentCategory is null)
            throw new IcarusException(404, "Department Category is not found");

        return this._mapper.Map<DepartmentCategoryForResultDto>(departmentCategory);
    }
}
