using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.Categories;
using Icarus.Service.Interfaces.Categories;
using Microsoft.AspNetCore.Mvc;

namespace Icarus.Api.Controllers.Categories
{
    public class CategoryController:BaseController
    {

        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] CategoryForCreationDto dto)
            => Ok(await _categoryService.CreateAsync(dto));

        [HttpGet]
        public async Task<IActionResult> SelectAllAsync([FromQuery] PaginationParams @params)
            =>Ok(await _categoryService.RetrieveAllAsync(@params));

        [HttpGet("{id}")]
        public async Task<IActionResult> SelectByIdAsync([FromRoute] long id)
            => Ok(await _categoryService.RetrieveByIdAsync(id));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] long id)
            =>Ok(await _categoryService.RemoveAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] long id, [FromBody] CategoryForUpdateDto dto)
            =>Ok(await _categoryService.ModifyAsync(id, dto));
    }
}
