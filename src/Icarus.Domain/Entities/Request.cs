using Icarus.Domain.Enums;
using Icarus.Domain.Commons;

namespace Icarus.Domain.Entities;
public class Request : Auditable<long>
{
    public long UserId { get; set; }
    public User FromWho { get; set; }

    public long DepartmentId { get; set; }
    public Department WhichDepartment { get; set; }

    public string RequestBody { get; set; }
    public string RequestTitle { get; set; }
    public Status Status { get; set; }

    public ICollection<DepartmentResponse> DepartmentResponses { get; set; }
}
