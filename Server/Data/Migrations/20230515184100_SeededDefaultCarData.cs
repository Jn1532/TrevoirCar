using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrevoirCar.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 5, 15, 13, 41, 0, 184, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 5, 15, 13, 41, 0, 187, DateTimeKind.Local).AddTicks(6175), "Black", "System" },
                    { 2, "System", new DateTime(2023, 5, 15, 13, 41, 0, 187, DateTimeKind.Local).AddTicks(7831), new DateTime(2023, 5, 15, 13, 41, 0, 187, DateTimeKind.Local).AddTicks(7849), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(1223), new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(1254), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(1615), new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(1626), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(5138), new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(5157), "Prius", "System" },
                    { 2, "System", new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(5626), new DateTime(2023, 5, 15, 13, 41, 0, 189, DateTimeKind.Local).AddTicks(5636), "3 Series", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
