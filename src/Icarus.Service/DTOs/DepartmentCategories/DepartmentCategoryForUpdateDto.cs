namespace Icarus.Service.DTOs.DepartmentCategories;

public class DepartmentCategoryForUpdateDto
{
    public long CategoryId { get; set; }
    public long DepartmentId { get; set; }
    public string Description { get; set; }
}
