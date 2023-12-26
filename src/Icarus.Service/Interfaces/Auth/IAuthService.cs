using Icarus.Service.DTOs.Auth;

namespace Icarus.Service.Interfaces.Auth;
public interface IAuthService
{
    Task<LoginResultDto> LoginAsync(LoginDto dto);
    Task<string> RegisterAsync(RegisterDto dto);
    Task<bool> ConfirmUserAsync(string code);
    Task<bool> SendEmailAsync(string userEmail);
}
