using Icarus.Domain.Commons;

namespace Icarus.Domain.Entities;
public class RolePermission:Auditable<int>
{
    public int RoleId { get; set; }
    public Role Role { get; set; }
    public int PermissionId { get; set; }
    public Permission Permission { get; set; }
}
