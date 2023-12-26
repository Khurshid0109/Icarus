using Icarus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Data.DbContexts.SeedDatas.SeedDataUsers;

public class SeedDataUser
{
    public static void SeedUsers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Phone = "123456789",
                Password = "john123456789",
                Image = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                Phone = "987654321",
                Password = "jane123456789",
                Image = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 3,
                FirstName = "Michael",
                LastName = "Johnson",
                Email = "michael.johnson@example.com",
                Phone = "555555555",
                Password = "michael123456789",
                Image = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 4,
                FirstName = "Emily",
                LastName = "Anderson",
                Email = "emily.anderson@example.com",
                Phone = "333333333",
                Password = "emily123456789",
                Image = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 5,
                FirstName = "William",
                LastName = "Taylor",
                Email = "william.taylor@example.com",
                Phone = "777777777",
                Password = "william123456789",
                Image = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                CreatedAt = DateTime.UtcNow
            }
        );
    }
}
