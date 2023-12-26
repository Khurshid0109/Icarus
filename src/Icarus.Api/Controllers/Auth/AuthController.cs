using Icarus.Service.DTOs.Auth;
using Icarus.Service.Interfaces.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Icarus.Api.Controllers.Auth;
public class AuthController:BaseController
{
    private readonly IAuthService _service;

    public AuthController(IAuthService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> RegisterAsync(RegisterDto dto)
        => Ok(await _service.RegisterAsync(dto));

    [HttpPost("Authenticate")]
    public async Task<IActionResult> LoginAsync(LoginDto loginDto)
        => Ok(await _service.LoginAsync(loginDto));

    [HttpGet("verify-email/{confirmData}")]
    public async Task<IActionResult> VerifyEmailAsync([FromRoute] string confirmData)
        => Ok(await _service.ConfirmUserAsync(confirmData));
}
