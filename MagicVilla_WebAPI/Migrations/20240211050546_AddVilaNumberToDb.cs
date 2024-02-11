using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddVilaNumberToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 10, 5, 46, 851, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 2, 11, 10, 5, 46, 851, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 10, 5, 46, 851, DateTimeKind.Local).AddTicks(1261), new DateTime(2024, 2, 11, 10, 5, 46, 851, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 10, 5, 46, 851, DateTimeKind.Local).AddTicks(1263), new DateTime(2024, 2, 11, 10, 5, 46, 851, DateTimeKind.Local).AddTicks(1264) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 50, 32, 133, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 2, 8, 21, 50, 32, 133, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 50, 32, 133, DateTimeKind.Local).AddTicks(6666), new DateTime(2024, 2, 8, 21, 50, 32, 133, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 50, 32, 133, DateTimeKind.Local).AddTicks(6668), new DateTime(2024, 2, 8, 21, 50, 32, 133, DateTimeKind.Local).AddTicks(6669) });
        }
    }
}
