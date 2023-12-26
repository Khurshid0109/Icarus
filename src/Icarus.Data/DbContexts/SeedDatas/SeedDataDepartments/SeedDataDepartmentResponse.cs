using Icarus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Data.DbContexts.SeedDatas.SeedDataDepartments;

public class SeedDataDepartmentResponse
{
    public static void SeedDepartmentResponses(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DepartmentResponse>().HasData(

            new DepartmentResponse
            {
                Id = 1,
                RequestId = 1,
                DepartmentId = 1,
                ResponseBody = "Moliya",
                CreatedAt = DateTime.UtcNow   
            },
            new DepartmentResponse
            {
                Id = 2,
                RequestId = 2,
                DepartmentId = 3,
                ResponseBody = "Iqtisodiyot",
                CreatedAt = DateTime.UtcNow
            },
            new DepartmentResponse
            {
                Id = 3,
                RequestId = 3,
                DepartmentId = 2,
                ResponseBody = "Biznes Ta'lim",
                CreatedAt = DateTime.UtcNow
            },
            new DepartmentResponse
            {
                Id = 4,
                RequestId = 4,
                DepartmentId = 5,
                ResponseBody = "Konsultatsiya",
                CreatedAt = DateTime.UtcNow
            },
            new DepartmentResponse
            {
                Id = 5,
                RequestId = 5,
                DepartmentId = 4,
                ResponseBody = "Ijtimoiy Himoya",
                CreatedAt = DateTime.UtcNow
            }


            );
    }
}
