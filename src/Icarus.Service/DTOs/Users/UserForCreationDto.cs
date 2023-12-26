using Icarus.Service.Helpers;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Icarus.Service.DTOs.Users
{
    public class UserForCreationDto
    {
        [Required, MinLength(3)]
        public string FirstName { get; set; }

        [Required, MinLength(3)]
        public string LastName { get; set; }

        [Required, IcarusEmailAttribute]
        public string Email { get; set; }

        [Required, PhoneAttribute]
        [RegularExpression(@"^\+?\d{1,7}?[-.\s]?\(?\d{1,4}?\)?[-.\s]?\d{1,10}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [Required, MinLength(8), MaxLength(32)] 
        public string Password { get; set; }
        public IFormFile Image { get; set; }

    }
}
