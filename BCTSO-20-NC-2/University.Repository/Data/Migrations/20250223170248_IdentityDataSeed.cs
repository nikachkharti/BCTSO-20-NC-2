using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace University.Repository.Migrations
{
    /// <inheritdoc />
    public partial class IdentityDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33B7ED72-9434-434A-82D4-3018B018CB87", null, "Admin", "ADMIN" },
                    { "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8716071C-1D9B-48FD-B3D0-F059C4FB8031", 0, "a67d8c94-4cf8-4b10-aa39-56aeb6d6135b", "admin@gmail.com", false, "Administrator", true, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEEoYrJrZlkAwl8UMCHiVuatguNt7edACJ5632qADG6+0xXqnErDdmjMfMg4e3rq6Fw==", "555337681", false, "13b8c030-84f4-4687-a58b-015824617fa5", false, "admin@gmail.com" },
                    { "87746F88-DC38-4756-924A-B95CFF3A1D8A", 0, "23d337d4-7917-4984-a922-d302ca89d2d0", "gio@gmail.com", false, "Giorgi Giorgadze", true, null, "GIO@GMAIL.COM", "GIO@GMAIL.COM", "AQAAAAIAAYagAAAAEDc7T5VvEjU2d6RV8U1EXA8xnZS5q6JFjHsUBoh6AQD3pkxBZaPadHOOvK6eu0qyKw==", "551442269", false, "35adb7db-90b4-4277-9298-ccc005e6c8c2", false, "gio@gmail.com" },
                    { "D514EDC9-94BB-416F-AF9D-7C13669689C9", 0, "4f36fab6-1df8-4a5a-ae8e-277486df39ef", "nika@gmail.com", false, "Nikoloz Chkhartishvili", true, null, "NIKA@GMAIL.COM", "NIKA@GMAIL.COM", "AQAAAAIAAYagAAAAEOvfvcf2gqT3WMEuNiznC47AcIWg8lEM46elDPESW+nmpCK7V6Q/0fOITBGJEVMUhg==", "558490645", false, "a972a5ba-ccfa-47b0-b881-e805f8c735c6", false, "nika@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "33B7ED72-9434-434A-82D4-3018B018CB87", "8716071C-1D9B-48FD-B3D0-F059C4FB8031" },
                    { "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", "87746F88-DC38-4756-924A-B95CFF3A1D8A" },
                    { "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", "D514EDC9-94BB-416F-AF9D-7C13669689C9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33B7ED72-9434-434A-82D4-3018B018CB87", "8716071C-1D9B-48FD-B3D0-F059C4FB8031" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", "87746F88-DC38-4756-924A-B95CFF3A1D8A" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", "D514EDC9-94BB-416F-AF9D-7C13669689C9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33B7ED72-9434-434A-82D4-3018B018CB87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9");
        }
    }
}
