using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrevoirCar.Server.Data.Migrations
{
    public partial class SeedAddRole2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 57, 15, 364, DateTimeKind.Local).AddTicks(5467), new DateTime(2023, 5, 15, 13, 57, 15, 368, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 57, 15, 368, DateTimeKind.Local).AddTicks(2045), new DateTime(2023, 5, 15, 13, 57, 15, 368, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 57, 15, 369, DateTimeKind.Local).AddTicks(6249), new DateTime(2023, 5, 15, 13, 57, 15, 369, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 57, 15, 369, DateTimeKind.Local).AddTicks(6651), new DateTime(2023, 5, 15, 13, 57, 15, 369, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 57, 15, 369, DateTimeKind.Local).AddTicks(9684), new DateTime(2023, 5, 15, 13, 57, 15, 369, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 57, 15, 370, DateTimeKind.Local).AddTicks(57), new DateTime(2023, 5, 15, 13, 57, 15, 370, DateTimeKind.Local).AddTicks(67) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
