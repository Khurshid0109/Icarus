using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.DepartmentResponses;
using Icarus.Service.DTOs.Departments;
using Icarus.Service.Interfaces.DepartmentResponses;
using Microsoft.AspNetCore.Mvc;

namespace Icarus.Api.Controllers;

public class DResponsesController : BaseController
{
    private readonly IDepartmentResponseService _responseService;

    public DResponsesController(IDepartmentResponseService responseService)
    {
        _responseService = responseService;
    }
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] DResponseForCreationDto dto)
        => Ok(await this._responseService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await _responseService.RetrieveAllAsync(@params));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._responseService.RetrieveByIdAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] DResponseForUpdateDto dto)
        => Ok(await this._responseService.ModifyAsync(id, dto));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._responseService.RemoveAsync(id));
}
