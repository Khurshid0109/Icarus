using Icarus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Data.DbContexts.SeedDatas.SeedDataAssets;

public class SeedDataAsset
{
    public static void SeedAssets(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asset>().HasData(
            new Asset
            {
                Id = 1,
                Logo = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                Email = "company1@gmail.com",   
                Phone = "1234567890",
                Rating = 5,
                Address = "Chilanzar 10 Kv",
                TelegramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                FacebookUrl = "http://yoshtadbirkor.uz/innoplatforma",
                InstagramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                CompanyWebUrl = "http://yoshtadbirkor.uz/innoplatforma",
                CreatedAt = DateTime.UtcNow,
            },
            new Asset
            {
                Id = 2,
                Logo = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                Email = "company2@gmail.com",
                Phone = "+998741231567",
                Rating = 3,
                Address = "Chilanzar 11 Kv",
                TelegramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                FacebookUrl = "http://yoshtadbirkor.uz/innoplatforma",
                InstagramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                CompanyWebUrl = "http://yoshtadbirkor.uz/innoplatforma",
                CreatedAt = DateTime.UtcNow,
            },
            new Asset
            {
                Id = 3,
                Logo = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                Email = "company3@gmail.com",
                Phone = "+998741234867",
                Rating = 5,
                Address = "Sergeli 10 Kv",
                TelegramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                FacebookUrl = "http://yoshtadbirkor.uz/innoplatforma",
                InstagramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                CompanyWebUrl = "http://yoshtadbirkor.uz/innoplatforma",
                CreatedAt = DateTime.UtcNow,
            },
            new Asset
            {
                Id = 4,
                Logo = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                Email = "company4@gmail.com",
                Phone = "+998741634567",
                Rating = 4,
                Address = "Sebzor 5 Kv",
                TelegramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                FacebookUrl = "http://yoshtadbirkor.uz/innoplatforma",
                InstagramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                CompanyWebUrl = "http://yoshtadbirkor.uz/innoplatforma",
                CreatedAt = DateTime.UtcNow,
            },
            new Asset
            {
                Id = 5,
                Logo = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                Email = "company5@gmail.com",
                Phone = "+998741232567",
                Rating = 5,
                Address = "Chilanzar 19 Kv",
                TelegramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                FacebookUrl = "http://yoshtadbirkor.uz/innoplatforma",
                InstagramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                CompanyWebUrl = "http://yoshtadbirkor.uz/innoplatforma",
                CreatedAt = DateTime.UtcNow,
            }
            );
    }

}