using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Icarus.Data.Migrations
{
    /// <inheritdoc />
    public partial class RolePermissionAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "RoleId" },
                values: new object[] { new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5236), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "RoleId" },
                values: new object[] { new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5245), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "RoleId" },
                values: new object[] { new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5248), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "RoleId" },
                values: new object[] { new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5251), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "RoleId" },
                values: new object[] { new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5254), null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4215), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4223), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4226), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4228), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2023, 12, 24, 5, 4, 26, 408, DateTimeKind.Utc).AddTicks(4230), 0 });
        }
    }
}
