using Icarus.Service.DTOs.Requests;
using Icarus.Service.DTOs.Departments;

namespace Icarus.Service.DTOs.DepartmentResponses;
public class DResponseForResultDto
{
    public long Id { get; set; }
    public string ResponseBody { get; set; }
    public RequestForResultDto Request { get; set; }
    //public DepartmentForResultDto WhichDepartment { get; set; }
}
