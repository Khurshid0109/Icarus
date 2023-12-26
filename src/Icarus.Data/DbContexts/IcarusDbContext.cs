using Icarus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Icarus.Data.DbContexts.SeedDatas.SeedDataUsers;
using Icarus.Data.DbContexts.SeedDatas.SeedDataAssets;
using Icarus.Data.DbContexts.SeedDatas.SeedDataRequests;
using Icarus.Data.DbContexts.SeedDatas.SeedDataCategories;
using Icarus.Data.DbContexts.SeedDatas.SeedDataDepartments;

namespace Icarus.Data.DbContexts;
public class IcarusDbContext : DbContext
{
    public IcarusDbContext(DbContextOptions<IcarusDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Asset> Assets { get; set; }
    public DbSet<Request> Requests { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DepartmentResponse> DepartmentResponses { get; set; }
    public DbSet<DepartmentCategory> DepartmentCategories { get; set; }
    public DbSet<BotUser> BotUsers { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // User Configuration
        modelBuilder.Entity<User>()
            .HasMany(u => u.Requests)
            .WithOne(r => r.FromWho)
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Request Configuration
        modelBuilder.Entity<Request>()
            .HasMany(r => r.DepartmentResponses)
            .WithOne(dr => dr.Request)
            .HasForeignKey(dr => dr.RequestId)
            .OnDelete(DeleteBehavior.Cascade);

        // Category Configuration
        modelBuilder.Entity<Category>()
            .HasMany(c => c.DepartmentCategories)
            .WithOne(d => d.Category)
            .HasForeignKey(d => d.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        // Department Configuration
        modelBuilder.Entity<Department>()
            .HasMany(d => d.DepartmentCategories)
            .WithOne(c => c.Department)
            .HasForeignKey(c => c.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);

        // DepartmentResponse Configuration
        modelBuilder.Entity<DepartmentResponse>()
            .HasOne(dr => dr.Request)
            .WithMany(r => r.DepartmentResponses)
            .HasForeignKey(dr => dr.RequestId)
            .OnDelete(DeleteBehavior.Cascade);

        // DepartmentResponse Configuration
        modelBuilder.Entity<DepartmentResponse>()
            .HasOne(dr => dr.WhichDepartment)
            .WithMany();

        // DepartmentCategory Configuration
        modelBuilder.Entity<DepartmentCategory>()
            .HasOne(dc => dc.Department)
            .WithMany(d => d.DepartmentCategories)
            .HasForeignKey(dc => dc.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);

        // DepartmentCategory Configuration
        modelBuilder.Entity<DepartmentCategory>()
            .HasOne(dc => dc.Category)
            .WithMany(c => c.DepartmentCategories)
            .HasForeignKey(dc => dc.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);


        SeedData(modelBuilder);
    }
    private static void SeedData(ModelBuilder modelBuilder)
    {
        SeedDataUser.SeedUsers(modelBuilder);
        SeedDataAsset.SeedAssets(modelBuilder);
        SeedDataRequest.SeedRequests(modelBuilder);
        SeedDataCategory.SeedCategories(modelBuilder);
        SeedDataDepartment.SeedDepartments(modelBuilder);
        SeedDataDepartmentCategory.SeedDepartmentCategories(modelBuilder);
        SeedDataDepartmentResponse.SeedDepartmentResponses(modelBuilder);
    }
}

