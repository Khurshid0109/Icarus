using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Icarus.Data.Migrations
{
    /// <inheritdoc />
    public partial class BotUserAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelegramId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "BotUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    TelegramId = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BotUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "DepartmentCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 462, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 462, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 462, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 462, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "DepartmentResponses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 462, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 9, 10, 21, 461, DateTimeKind.Utc).AddTicks(9508));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BotUsers");

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
    }
}
