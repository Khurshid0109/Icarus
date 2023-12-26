using Icarus.Domain.Commons;

namespace Icarus.Domain.Entities;
public class Permission:Auditable<int>
{
    public string Name { get; set; }
}
