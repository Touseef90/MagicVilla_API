using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewForeignKeyVillaID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6210), new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6223), new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillaNumbers");

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
    }
}
