
namespace Icarus.Service.DTOs.Users
{
    public class UserForResultDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsConfirmed { get; set; }
        public string Image { get; set; }
    }
}
