using Icarus.Service.DTOs.Categories;
using Icarus.Service.DTOs.Departments;

namespace Icarus.Service.DTOs.DepartmentCategories;

public class DepartmentCategoryForResultDto
{
    public long Id { get; set; }
    public string Description { get; set; }
    public CategoryForResultDto Category { get; set; }
    public DepartmentForResultDto Department { get; set; }

}
