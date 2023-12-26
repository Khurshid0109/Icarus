using Icarus.Domain.Commons;

namespace Icarus.Domain.Entities;
public class Asset : Auditable<long>
{
    public string Logo { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public decimal Rating { get; set; }
    public string TelegramUrl { get; set; }
    public string FacebookUrl { get; set; }
    public string InstagramUrl { get; set; }
    public string CompanyWebUrl { get; set; }
   
}
