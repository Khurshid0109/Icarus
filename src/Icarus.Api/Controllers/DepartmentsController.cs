using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.Departments;
using Icarus.Service.Interfaces.Departments;
using Microsoft.AspNetCore.Mvc;

namespace Icarus.Api.Controllers;

public class DepartmentsController : BaseController
{
    private readonly IDepartmentService _departmentsService;

    public DepartmentsController(IDepartmentService departmentsService)
    {
        _departmentsService = departmentsService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] DepartmentForCreationDto dto)
        => Ok(await this._departmentsService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await _departmentsService.RetrieveAllAsync(@params));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._departmentsService.RetrieveByIdAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] DepartmentForUpdateDto dto)
        => Ok(await this._departmentsService.ModifyAsync(id, dto));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._departmentsService.RemoveAsync(id));
}
