using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.Assets;
using Icarus.Service.Interfaces.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Icarus.Api.Controllers.Assets;

public class AssetsController : BaseController
{
    private readonly IAssetService _assetService;

    public AssetsController(IAssetService assetService)
    {
        this._assetService = assetService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromForm] AssetForCreationDto dto)
           => Ok(await this._assetService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await this._assetService.RetrieveAllAsync(@params));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._assetService.RetrieveByIdAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromForm] AssetForUpdateDto dto)
        => Ok(await this._assetService.ModifyAsync(id, dto));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
       => Ok(await this._assetService.RemoveAsync(id));
}
