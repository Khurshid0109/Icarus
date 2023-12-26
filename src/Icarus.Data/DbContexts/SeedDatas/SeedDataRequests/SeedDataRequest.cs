using Icarus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Data.DbContexts.SeedDatas.SeedDataRequests;

public class SeedDataRequest
{
    public static void SeedRequests(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Request>().HasData(
            new Request
            {
                Id = 1,
                UserId = 2,
                DepartmentId = 1,
                RequestBody = "Moliya",
                RequestTitle = "I have best idea for these project ALATOR",
                CreatedAt = DateTime.UtcNow
            },
            new Request
            {
                Id = 2,
                UserId = 1,
                DepartmentId = 3,
                RequestBody = "Iqtisodiyot",
                RequestTitle = "I have best idea for these project ALATOR",
                CreatedAt = DateTime.UtcNow
            },
            new Request
            {
                Id = 3,
                UserId = 5,
                DepartmentId = 2,
                RequestBody = "Biznes Ta'lim",
                RequestTitle = "i hope to study at Haad Lc",
                CreatedAt = DateTime.UtcNow
            },
            new Request
            {
                Id = 4,
                UserId = 3,
                DepartmentId = 5,
                RequestBody = "Konsultatsiya",
                RequestTitle = "I have best idea for these project ALATOR",
                CreatedAt = DateTime.UtcNow
            },
            new Request
            {
                Id = 5,
                UserId = 4,
                DepartmentId = 4,
                RequestBody = "Ijtimoiy Himoya",
                RequestTitle = "I have need a lot money",
                CreatedAt = DateTime.UtcNow
            }

            );
    }
}
