using Icarus.Service.Helpers;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Icarus.Service.DTOs.Assets;

public class AssetForUpdateDto
{
    public IFormFile Logo { get; set; }
    public decimal Rating { get; set; }
    [PhoneAttribute]
    public string Phone { get; set; }

    [IcarusEmailAttribute]
    public string Email { get; set; }
    public string Address { get; set; }

    [UrlAttribute]
    public string CompanyWebUrl { get; set; }

    [UrlAttribute]
    public string InstagramUrl { get; set; }

    [UrlAttribute]
    public string TelegramUrl { get; set; }

    [UrlAttribute]
    public string FacebookUrl { get; set; }
}
