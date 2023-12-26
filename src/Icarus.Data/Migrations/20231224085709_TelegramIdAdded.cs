using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Icarus.Data.Migrations
{
    /// <inheritdoc />
    public partial class TelegramIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TelegramId",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "TelegramId" },
                values: new object[] { new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(5728), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "TelegramId" },
                values: new object[] { new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(5739), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "TelegramId" },
                values: new object[] { new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(5744), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "TelegramId" },
                values: new object[] { new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(5750), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "TelegramId" },
                values: new object[] { new DateTime(2023, 12, 24, 8, 57, 8, 152, DateTimeKind.Utc).AddTicks(5755), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelegramId",
                table: "Users");

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
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 7, 12, 16, 62, DateTimeKind.Utc).AddTicks(5254));
        }
    }
}
