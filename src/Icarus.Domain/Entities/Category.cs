using Icarus.Domain.Commons;

namespace Icarus.Domain.Entities;
public class Category : Auditable<long>
{
    public string Name { get; set; }
    public ICollection<DepartmentCategory> DepartmentCategories { get; set; }
}
