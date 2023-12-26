using Icarus.Domain.Commons;

namespace Icarus.Domain.Entities;
public class Role:Auditable<int>
{
    public string Name { get; set; }
}
