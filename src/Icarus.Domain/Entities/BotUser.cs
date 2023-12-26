using Icarus.Domain.Commons;

namespace Icarus.Domain.Entities;
public class BotUser:Auditable<long>
{
    public string FullName { get; set; }
    public long TelegramId { get; set; }
    public string PhoneNumber { get; set; }
}
