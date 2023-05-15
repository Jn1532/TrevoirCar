using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrevoirCar.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "990f4071-6b78-476f-bef2-c7665515e6f4",
                column: "ConcurrencyStamp",
                value: "b91749ac-0ae5-4ed6-8666-220d5b465153");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "990f4071-6b78-476f-bef2-c7665515e6f5",
                column: "ConcurrencyStamp",
                value: "a0a6f33a-f37e-4dc8-b923-f9bc878eb413");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5a6df2c4-69ac-4b7a-af58-951a1e46b21d", 0, "1a325b67-2c21-4133-96ec-d432e016b7e7", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAENxOkKNpVkkZhJyUqX/11qhcs94hka3ODXSUgfdBw3QZ74c+/MUvwSKGcX4kl1FReg==", null, false, "fc71eef5-94b2-4f2c-bf72-6f6905b06871", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 33, 40, 120, DateTimeKind.Local).AddTicks(4080), new DateTime(2023, 5, 15, 15, 33, 40, 123, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 33, 40, 123, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 5, 15, 15, 33, 40, 123, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 33, 40, 124, DateTimeKind.Local).AddTicks(7440), new DateTime(2023, 5, 15, 15, 33, 40, 124, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 33, 40, 124, DateTimeKind.Local).AddTicks(7844), new DateTime(2023, 5, 15, 15, 33, 40, 124, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 33, 40, 125, DateTimeKind.Local).AddTicks(944), new DateTime(2023, 5, 15, 15, 33, 40, 125, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 33, 40, 125, DateTimeKind.Local).AddTicks(1329), new DateTime(2023, 5, 15, 15, 33, 40, 125, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "990f4071-6b78-476f-bef2-c7665515e6f4", "5a6df2c4-69ac-4b7a-af58-951a1e46b21d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "990f4071-6b78-476f-bef2-c7665515e6f4", "5a6df2c4-69ac-4b7a-af58-951a1e46b21d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a6df2c4-69ac-4b7a-af58-951a1e46b21d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "990f4071-6b78-476f-bef2-c7665515e6f4",
                column: "ConcurrencyStamp",
                value: "08f7181f-7f44-4d3a-b674-ebfeb9c14148");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "990f4071-6b78-476f-bef2-c7665515e6f5",
                column: "ConcurrencyStamp",
                value: "d9597586-ff63-449e-97cb-f6b9e20d1d84");

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
    }
}
