using Icarus.Domain.Enums;
using Icarus.Domain.Entities;
using Icarus.Service.DTOs.Users;
using Icarus.Service.DTOs.Departments;

namespace Icarus.Service.DTOs.Requests;
public class RequestForResultDto
{
    public long Id { get; set; }
    public Status Status { get; set; }
    public string RequestBody { get; set; }
    public string RequestTitle { get; set; }
    public UserForResultDto FromWho { get; set; }
    public DepartmentForResultDto WhichDepartment { get; set; }
}
