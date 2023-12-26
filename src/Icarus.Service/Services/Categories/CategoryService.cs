using AutoMapper;
using Icarus.Domain.Entities;
using Icarus.Service.Exceptions;
using Icarus.Data.IRepositories;
using Icarus.Domain.Configurations;
using Microsoft.EntityFrameworkCore;
using Icarus.Service.DTOs.Categories;
using Icarus.Service.Commons.Extensions;
using Icarus.Service.Interfaces.Categories;

namespace Icarus.Service.Services.Categories;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    public CategoryService(IMapper mapper, ICategoryRepository categoryRepository)
    {
        _mapper = mapper;
        _categoryRepository = categoryRepository;
    }
    public async Task<CategoryForResultDto> CreateAsync(CategoryForCreationDto dto)
    {
        var category = await _categoryRepository.SelectAll()
            .Where(c => c.Name.ToLower() == dto.Name.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (category is not null)
            throw new IcarusException(409, "Category is already exist");

        var mappedCategory = _mapper.Map<Category>(dto);

        var result = await _categoryRepository.InsertAsync(mappedCategory);
        await _categoryRepository.SaveAsync();

        return this._mapper.Map<CategoryForResultDto>(result);
    }

    public async Task<CategoryForResultDto> ModifyAsync(long id, CategoryForUpdateDto dto)
    {
        var category = await _categoryRepository.SelectAll()
                .Where(ud => ud.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (category is null)
            throw new IcarusException(404, "Category is not found");

        var mappedCategory = this._mapper.Map(dto, category);
        mappedCategory.UpdatedAt = DateTime.UtcNow;

        var result = await this._categoryRepository.UpdateAsync(mappedCategory);
        await _categoryRepository.SaveAsync();

        return this._mapper.Map<CategoryForResultDto>(result);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var category = await _categoryRepository.SelectAll()
              .Where(c => c.Id == id)
              .AsNoTracking()
              .FirstOrDefaultAsync();

        if (category is null)
            throw new IcarusException(404, "Category is not found!");
        
        var result = await _categoryRepository.DeleteAsync(id);
        await _categoryRepository.SaveAsync();
        
        return result;

    }

    public async Task<IEnumerable<CategoryForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var category = await _categoryRepository.SelectAll()
                .Include(c => c.DepartmentCategories)
                .AsNoTracking()
                .ToPagedList<Category, long>(@params)
                .ToListAsync();

        return _mapper.Map<IEnumerable<CategoryForResultDto>>(category);
    }

    public async Task<CategoryForResultDto> RetrieveByIdAsync(long id)
    {
        var category = await this._categoryRepository.SelectAll()
                .Where(c => c.Id == id)
                .Include(dc => dc.DepartmentCategories)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (category is null)
            throw new IcarusException(404, "Category is not found");

        return this._mapper.Map<CategoryForResultDto>(category);
    }
}
