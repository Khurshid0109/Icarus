using Icarus.Data.IRepositories;
using Icarus.Domain.Configurations;
using Icarus.Service.DTOs.Categories;
using Icarus.Service.DTOs.Requests;
using Icarus.Service.Interfaces.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Icarus.Api.Controllers.Requests
{
    public class RequestsController : BaseController
    {
        private readonly IRequestService _requestService;
        public RequestsController(IRequestService requestService)
        {
            _requestService = requestService;
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] RequestForCreationDto dto)
            => Ok(await _requestService.CreateAsync(dto));

        [HttpGet]
        public async Task<IActionResult> SelectAllAsync([FromQuery] PaginationParams @params)
            => Ok(await _requestService.RetrieveAllAsync(@params));

        [HttpGet("{id}")]
        public async Task<IActionResult> SelectByIdAsync([FromRoute] long id)
            => Ok(await _requestService.RetrieveByIdAsync(id));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] long id)
            => Ok(await _requestService.RemoveAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] long id, [FromBody] RequestForUpdateDto dto)
            => Ok(await _requestService.ModifyAsync(id, dto));
    }
}
