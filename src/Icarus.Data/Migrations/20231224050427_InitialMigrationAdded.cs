using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Icarus.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Logo = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Rating = table.Column<decimal>(type: "numeric", nullable: false),
                    TelegramUrl = table.Column<string>(type: "text", nullable: true),
                    FacebookUrl = table.Column<string>(type: "text", nullable: true),
                    InstagramUrl = table.Column<string>(type: "text", nullable: true),
                    CompanyWebUrl = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    IsConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssetId = table.Column<long>(type: "bigint", nullable: false),
                    Rating = table.Column<decimal>(type: "numeric", nullable: false),
                    Latitude = table.Column<string>(type: "text", nullable: true),
                    Longitude = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentCategories_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    RequestBody = table.Column<string>(type: "text", nullable: true),
                    RequestTitle = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentResponses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    ResponseBody = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentResponses_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentResponses_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Address", "CompanyWebUrl", "CreatedAt", "Email", "FacebookUrl", "InstagramUrl", "Logo", "Phone", "Rating", "TelegramUrl", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "Chilanzar 10 Kv", "http://yoshtadbirkor.uz/innoplatforma", new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4697), "company1@gmail.com", "http://yoshtadbirkor.uz/innoplatforma", "http://yoshtadbirkor.uz/innoplatforma", "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png", "1234567890", 5m, "http://yoshtadbirkor.uz/innoplatforma", null },
                    { 2L, "Chilanzar 11 Kv", "http://yoshtadbirkor.uz/innoplatforma", new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4701), "company2@gmail.com", "http://yoshtadbirkor.uz/innoplatforma", "http://yoshtadbirkor.uz/innoplatforma", "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png", "+998741231567", 3m, "http://yoshtadbirkor.uz/innoplatforma", null },
                    { 3L, "Sergeli 10 Kv", "http://yoshtadbirkor.uz/innoplatforma", new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4783), "company3@gmail.com", "http://yoshtadbirkor.uz/innoplatforma", "http://yoshtadbirkor.uz/innoplatforma", "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png", "+998741234867", 5m, "http://yoshtadbirkor.uz/innoplatforma", null },
                    { 4L, "Sebzor 5 Kv", "http://yoshtadbirkor.uz/innoplatforma", new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4787), "company4@gmail.com", "http://yoshtadbirkor.uz/innoplatforma", "http://yoshtadbirkor.uz/innoplatforma", "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png", "+998741634567", 4m, "http://yoshtadbirkor.uz/innoplatforma", null },
                    { 5L, "Chilanzar 19 Kv", "http://yoshtadbirkor.uz/innoplatforma", new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4791), "company5@gmail.com", "http://yoshtadbirkor.uz/innoplatforma", "http://yoshtadbirkor.uz/innoplatforma", "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png", "+998741232567", 5m, "http://yoshtadbirkor.uz/innoplatforma", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4912), "Moliyalashtirish", null },
                    { 2L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4914), "Konsultatsiya", null },
                    { 3L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4915), "Iqtisodiyot", null },
                    { 4L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4917), "Tijorat", null },
                    { 5L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4919), "Biznes Ta'lim", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "Image", "IsConfirmed", "LastName", "Password", "Phone", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4215), "john.doe@example.com", "John", "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png", false, "Doe", "john123456789", "123456789", 0, null },
                    { 2L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4223), "jane.smith@example.com", "Jane", "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png", false, "Smith", "jane123456789", "987654321", 0, null },
                    { 3L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4226), "michael.johnson@example.com", "Michael", "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png", false, "Johnson", "michael123456789", "555555555", 0, null },
                    { 4L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4228), "emily.anderson@example.com", "Emily", "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png", false, "Anderson", "emily123456789", "333333333", 0, null },
                    { 5L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4230), "william.taylor@example.com", "William", "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png", false, "Taylor", "william123456789", "777777777", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "AssetId", "CreatedAt", "Latitude", "Longitude", "Rating", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4973), "41.279390", "69.197976", 5m, null },
                    { 2L, 2L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4976), "40.7128", "-74.0060", 5m, null },
                    { 3L, 3L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4979), "48.8566", "2.3522", 4m, null },
                    { 4L, 4L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4982), "35.6895", "139.6917", 4m, null },
                    { 5L, 5L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4984), "-33.8688", "151.2093", 3m, null }
                });

            migrationBuilder.InsertData(
                table: "DepartmentCategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DepartmentId", "Description", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 2L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5030), 5L, "Assalomu Alaykum !", null },
                    { 2L, 3L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5034), 1L, "Assalomu Alaykum !", null },
                    { 3L, 4L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5036), 4L, "Assalomu Alaykum !", null },
                    { 4L, 5L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5038), 3L, "Assalomu Alaykum !", null },
                    { 5L, 1L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5040), 2L, "Assalomu Alaykum !", null }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "RequestBody", "RequestTitle", "Status", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4852), 1L, "Moliya", "I have best idea for these project ALATOR", 0, null, 2L },
                    { 2L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4854), 3L, "Iqtisodiyot", "I have best idea for these project ALATOR", 0, null, 1L },
                    { 3L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4857), 2L, "Biznes Ta'lim", "i hope to study at Haad Lc", 0, null, 5L },
                    { 4L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4859), 5L, "Konsultatsiya", "I have best idea for these project ALATOR", 0, null, 3L },
                    { 5L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4861), 4L, "Ijtimoiy Himoya", "I have need a lot money", 0, null, 4L }
                });

            migrationBuilder.InsertData(
                table: "DepartmentResponses",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "RequestId", "ResponseBody", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5093), 1L, 1L, "Moliya", null },
                    { 2L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5095), 3L, 2L, "Iqtisodiyot", null },
                    { 3L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5096), 2L, 3L, "Biznes Ta'lim", null },
                    { 4L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5098), 5L, 4L, "Konsultatsiya", null },
                    { 5L, new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5101), 4L, 5L, "Ijtimoiy Himoya", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCategories_CategoryId",
                table: "DepartmentCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCategories_DepartmentId",
                table: "DepartmentCategories",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentResponses_DepartmentId",
                table: "DepartmentResponses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentResponses_RequestId",
                table: "DepartmentResponses",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_AssetId",
                table: "Departments",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_DepartmentId",
                table: "Requests",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentCategories");

            migrationBuilder.DropTable(
                name: "DepartmentResponses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Assets");
        }
    }
}
