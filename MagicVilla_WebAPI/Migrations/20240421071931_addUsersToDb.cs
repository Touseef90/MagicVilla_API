using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 12, 19, 31, 489, DateTimeKind.Local).AddTicks(9851), "https://dotnetmastery.com/bluevillaimages/villa3.jpg", new DateTime(2024, 4, 21, 12, 19, 31, 489, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 12, 19, 31, 489, DateTimeKind.Local).AddTicks(9868), "https://dotnetmastery.com/bluevillaimages/villa1.jpg", new DateTime(2024, 4, 21, 12, 19, 31, 489, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 12, 19, 31, 489, DateTimeKind.Local).AddTicks(9870), "https://dotnetmastery.com/bluevillaimages/villa2.jpg", new DateTime(2024, 4, 21, 12, 19, 31, 489, DateTimeKind.Local).AddTicks(9870) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 44, 44, 955, DateTimeKind.Local).AddTicks(5543), "", new DateTime(2024, 3, 5, 19, 44, 44, 955, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 44, 44, 955, DateTimeKind.Local).AddTicks(5555), "", new DateTime(2024, 3, 5, 19, 44, 44, 955, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 44, 44, 955, DateTimeKind.Local).AddTicks(5557), "", new DateTime(2024, 3, 5, 19, 44, 44, 955, DateTimeKind.Local).AddTicks(5557) });
        }
    }
}
