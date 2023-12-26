using Icarus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Data.DbContexts.SeedDatas.SeedDataDepartments;

public class SeedDataDepartment
{
    public static void SeedDepartments(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>().HasData
        (
            new Department
            {
                Id = 1,
                AssetId = 1,
                Latitude = "41.279390",
                Longitude = "69.197976",
                Rating = 5,
                CreatedAt = DateTime.UtcNow,
            },
            new Department
            {
                Id = 2,
                AssetId = 2,
                Latitude = "40.7128",
                Longitude = "-74.0060",
                Rating = 5,
                CreatedAt = DateTime.UtcNow,
            },
            new Department
            {
                Id = 3,
                AssetId = 3,
                Latitude = "48.8566",
                Longitude = "2.3522",
                Rating = 4,
                CreatedAt = DateTime.UtcNow,
            },
            new Department
            {
                Id = 4,
                AssetId = 4,
                Latitude = "35.6895",
                Longitude = "139.6917",
                Rating = 4,
                CreatedAt = DateTime.UtcNow,
            },
            new Department
            {
                Id = 5,
                AssetId = 5,
                Latitude = "-33.8688",
                Longitude = "151.2093",
                Rating = 3,
                CreatedAt = DateTime.UtcNow,
            }
        );
    }
}
