namespace Icarus.Service.DTOs.DepartmentCategories;

public class DepartmentCategoryForCreationDto
{
    public long CategoryId { get; set; }
    public long DepartmentId { get; set; }
    public string Description { get; set; }
}
