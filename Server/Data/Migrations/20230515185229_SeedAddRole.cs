using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrevoirCar.Server.Data.Migrations
{
    public partial class SeedAddRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 52, 29, 62, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 5, 15, 13, 52, 29, 65, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 52, 29, 65, DateTimeKind.Local).AddTicks(1933), new DateTime(2023, 5, 15, 13, 52, 29, 65, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 52, 29, 66, DateTimeKind.Local).AddTicks(5032), new DateTime(2023, 5, 15, 13, 52, 29, 66, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 52, 29, 66, DateTimeKind.Local).AddTicks(5430), new DateTime(2023, 5, 15, 13, 52, 29, 66, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 52, 29, 66, DateTimeKind.Local).AddTicks(8478), new DateTime(2023, 5, 15, 13, 52, 29, 66, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 52, 29, 66, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 5, 15, 13, 52, 29, 66, DateTimeKind.Local).AddTicks(8867) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 41, 0, 184, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 5, 15, 13, 41, 0, 187, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 41, 0, 187, DateTimeKind.Local).AddTicks(7831), new DateTime(2023, 5, 15, 13, 41, 0, 187, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(1223), new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(1615), new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(5138), new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(5626), new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(5636) });
        }
    }
}
