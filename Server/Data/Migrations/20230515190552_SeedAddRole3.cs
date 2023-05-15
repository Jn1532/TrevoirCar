using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrevoirCar.Server.Data.Migrations
{
    public partial class SeedAddRole3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "990f4071-6b78-476f-bef2-c7665515e6f5", "d9597586-ff63-449e-97cb-f6b9e20d1d84", "User", "USER" },
                    { "990f4071-6b78-476f-bef2-c7665515e6f4", "08f7181f-7f44-4d3a-b674-ebfeb9c14148", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 14, 5, 51, 538, DateTimeKind.Local).AddTicks(2638), new DateTime(2023, 5, 15, 14, 5, 51, 542, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 14, 5, 51, 543, DateTimeKind.Local).AddTicks(1369), new DateTime(2023, 5, 15, 14, 5, 51, 543, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 14, 5, 51, 545, DateTimeKind.Local).AddTicks(8827), new DateTime(2023, 5, 15, 14, 5, 51, 545, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 14, 5, 51, 545, DateTimeKind.Local).AddTicks(9627), new DateTime(2023, 5, 15, 14, 5, 51, 545, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 14, 5, 51, 546, DateTimeKind.Local).AddTicks(5221), new DateTime(2023, 5, 15, 14, 5, 51, 546, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 14, 5, 51, 546, DateTimeKind.Local).AddTicks(5783), new DateTime(2023, 5, 15, 14, 5, 51, 546, DateTimeKind.Local).AddTicks(5799) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "990f4071-6b78-476f-bef2-c7665515e6f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "990f4071-6b78-476f-bef2-c7665515e6f5");

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
    }
}
