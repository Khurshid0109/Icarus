using Icarus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Data.DbContexts.SeedDatas.SeedDataDepartments;

public class SeedDataDepartmentCategory
{
    public static void SeedDepartmentCategories(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DepartmentCategory>().HasData(

            new DepartmentCategory
            {
                Id = 1,
                CategoryId = 2,
                DepartmentId = 5,
                Description = "Assalomu Alaykum !",
                CreatedAt = DateTime.UtcNow
            },
            new DepartmentCategory
            {
                Id = 2,
                CategoryId = 3,
                DepartmentId = 1,
                Description = "Assalomu Alaykum !",
                CreatedAt = DateTime.UtcNow
            },
            new DepartmentCategory
            {
                Id = 3,
                CategoryId = 4,
                DepartmentId = 4,
                Description = "Assalomu Alaykum !",
                CreatedAt = DateTime.UtcNow
            },
            new DepartmentCategory
            {
                Id = 4,
                CategoryId = 5,
                DepartmentId = 3,
                Description = "Assalomu Alaykum !",
                CreatedAt = DateTime.UtcNow
            },
            new DepartmentCategory
            {
                Id = 5,
                CategoryId = 1,
                DepartmentId = 2,
                Description = "Assalomu Alaykum !",
                CreatedAt = DateTime.UtcNow
            }

            );
    }
}
