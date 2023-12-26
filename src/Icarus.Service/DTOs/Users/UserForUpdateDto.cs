using Icarus.Service.Helpers;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Icarus.Service.DTOs.Users
{
    public class UserForUpdateDto
    {
        [Required,MinLength(3)]
        public string FirstName { get; set; }

        [Required,MinLength(3)]
        public string LastName { get; set; }

        [IcarusEmailAttribute]
        public string Email { get; set; }

        [PhoneAttribute]
        public string Phone { get; set; }
        public string Password { get; set; }
        public IFormFile Image { get; set; }
    }
}
