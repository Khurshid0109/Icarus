using Icarus.Domain.Commons;

namespace Icarus.Domain.Entities;
public class DepartmentCategory : Auditable<long>
{
    public long DepartmentId { get; set; }
    public Department Department { get; set; }

    public long CategoryId { get; set; }
    public Category Category { get; set; }

    public string Description { get; set; }
}
