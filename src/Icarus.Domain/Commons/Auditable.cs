namespace Icarus.Domain.Commons;
public class Auditable<TKey>
{
    public TKey Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted = false;
}
