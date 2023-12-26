using MimeKit;
using AutoMapper;
using System.Text;
using MimeKit.Text;
using MailKit.Security;
using Icarus.Service.Helpers;
using Icarus.Domain.Entities;
using System.Security.Claims;
using Icarus.Service.DTOs.Auth;
using Icarus.Service.Exceptions;
using Microsoft.EntityFrameworkCore;
using Icarus.Service.Helpers.Hasher;
using Microsoft.IdentityModel.Tokens;
using Icarus.Service.Commons.Helpers;
using Icarus.Service.Interfaces.Auth;
using Icarus.Data.IRepositories.Users;
using System.IdentityModel.Tokens.Jwt;
using Icarus.Service.DTOs.Messages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;


namespace Icarus.Service.Services.Auth;
public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    private readonly IConfiguration _config;
    private readonly IMemoryCache _memoryCache;

    public AuthService(IUserRepository userRepository, IMapper mapper,
                       IConfiguration config, IMemoryCache memoryCache)
    {
        _userRepository = userRepository;
        _mapper = mapper;
        _config = config;
        _memoryCache = memoryCache;
    }

    public async Task<LoginResultDto> LoginAsync(LoginDto dto)
    {
        var password = HashPasswordHelper.PasswordHasher(dto.Password);

        var user = await _userRepository.SelectAll()
            .Where(u => u.Email.ToLower() == dto.Email.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (user is null || HashPasswordHelper.IsEqual(user.Password, dto.Password) || user.IsConfirmed == false)
            throw new IcarusException(405, "Login or password is incorrect");


        return new LoginResultDto
        {
            Token = GenerateToken(user)
        };
    }

    public async Task<string> RegisterAsync(RegisterDto dto)
    {
        var user = await _userRepository.SelectAll()
             .Where(u => u.Email.ToLower() == dto.Email.ToLower() || u.Phone == dto.Phone)
             .AsNoTracking()
             .FirstOrDefaultAsync();

        if (user is not null)
            throw new IcarusException(409, "User is already exist!");

        var mapped = _mapper.Map<User>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        mapped.Password = HashPasswordHelper.PasswordHasher(dto.Password);
        
        mapped.Image = Path.Combine(WebHostEnvironmentHelper.WebRootPath, "Logo", "UserLogo.png");

        var result = await _userRepository.InsertAsync(mapped);
        await _userRepository.SaveAsync();

        await SendEmailAsync(result.Email);

        return "Please verify your email!";
    }

    public async Task<bool> SendEmailAsync(string userEmail)
    {
        var Code = Guid.NewGuid().ToString();

        _memoryCache.Set(userEmail, Code, TimeSpan.FromMinutes(5));

        var encodedString = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Code}&{userEmail}"));

        var emailMessage = new EmailMessage()
        {
            To = userEmail,
            Subject = "Verification code",
            Body = @$"
    <p>Hi {userEmail} this message was sent you from Icarus please click button bellow to verify your account
            {DateTime.UtcNow}</p>
    <button style=""background-color: #2196F3; 
        color: white;
        border: none;
        padding: 30px 60px; 
        text-align: center; 
        text-decoration: none; 
        display: inline-block;
        font-size: 20px; 
        border-radius: 5px;"">
            <a href=""http://{HttpContextHelper.HttpContext.Request.Host.Value}/api/auth/verify-email/{encodedString}"" style=""color: white; 
                text-decoration: none;"">Verify</a>
    </button>"
        };

        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse(_config["Email:EmailAddress"]));
        email.To.Add(MailboxAddress.Parse(emailMessage.To));
        email.Subject = emailMessage.Subject;
        email.Body = new TextPart(TextFormat.Html) { Text = emailMessage.Body };

        var smtp = new MailKit.Net.Smtp.SmtpClient();
        await smtp.ConnectAsync(_config["Email:Host"], 587, SecureSocketOptions.StartTls);
        await smtp.AuthenticateAsync(_config["Email:EmailAddress"], _config["Email:Password"]);
        await smtp.SendAsync(email);

        return true;
    }


    public async Task<bool> ConfirmUserAsync(string code)
    {
        // user confirm data decoding proccess;
        var userConfirmData = Encoding.UTF8.GetString(Convert.FromBase64String(code));
        var splitedUserData = userConfirmData.Split("&");

        if (splitedUserData.Length != 2)
            throw new IcarusException(409, "User data is not correct format");


        var splitedCode = splitedUserData[0];
        var email = splitedUserData[1];

        var cashedValue = _memoryCache.Get<string>(email);

        var user = await _userRepository.SelectAll()
               .Where(u => u.Email.ToLower() == email.ToLower())
               .AsNoTracking()
               .FirstOrDefaultAsync();

        if (cashedValue?.ToString() == splitedCode)
        {
            user.IsConfirmed = true;
            await _userRepository.UpdateAsync(user);
            await _userRepository.SaveAsync();
        }
        else
        {
            await _userRepository.DeleteAsync(user.Id);
            await _userRepository.SaveAsync();
            return false;
        }

        return true;
    }
    // Generate JWT token
    private string GenerateToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenKey = Encoding.UTF8.GetBytes(_config["JWT:Key"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                 new Claim("Id", user.Id.ToString()),
                // new Claim(ClaimTypes.Role,user.Role.ToString()),
                 new Claim(ClaimTypes.Email, user.Email),
            }),
            Audience = _config["JWT:Audience"],
            Issuer = _config["JWT:Issuer"],
            IssuedAt = DateTime.UtcNow,
            Expires = DateTime.UtcNow.AddMinutes(double.Parse(_config["JWT:Expire"])),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}
