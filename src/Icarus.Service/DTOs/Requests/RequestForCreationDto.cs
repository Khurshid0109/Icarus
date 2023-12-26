
namespace Icarus.Service.DTOs.Requests;
public class RequestForCreationDto
{
    public long UserId { get; set; }
    public long DepartmentId { get; set; }
    public string RequestBody { get; set; }
    public string RequestTitle { get; set; }
}
