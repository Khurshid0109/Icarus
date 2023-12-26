using Icarus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Data.DbContexts.SeedDatas.SeedDataCategories;

public class SeedDataCategory
{
    public static void SeedCategories(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Moliyalashtirish",
                CreatedAt = DateTime.UtcNow,
            },
            new Category
            {
                Id = 2,
                Name = "Konsultatsiya",
                CreatedAt = DateTime.UtcNow,
            },
            new Category
            {
                Id = 3,
                Name = "Iqtisodiyot",
                CreatedAt = DateTime.UtcNow,
            },
            new Category
            {
                Id = 4,
                Name = "Tijorat",
                CreatedAt = DateTime.UtcNow,
            },
            new Category
            {
                Id = 5,
                Name = "Biznes Ta'lim",
                CreatedAt = DateTime.UtcNow,
            }
        );
    }
}