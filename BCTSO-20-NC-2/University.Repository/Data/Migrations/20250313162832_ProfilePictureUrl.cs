using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ProfilePictureUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureUrl",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfilePictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfilePictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8747f1c3-4c82-4fcc-b9df-d732fb308988", "AQAAAAIAAYagAAAAECoRE9USF9+2vOO8U6fQF8FD0l4bPRe5uEAOZ/m8qtlyG/gvCXgh2/M4sKqlqsE7oA==", "d456f646-5e63-4322-92f8-f32b42818e11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18942190-697b-4bc8-9979-7fb11ecb0a3b", "AQAAAAIAAYagAAAAEOXscQw3R/gpHcqiyKPTvjT3CWcg/dk8Yvqxo5NaTLbqCcIWKolRbEaD1k7XcKTl6w==", "2da2c72c-dcbf-4380-977d-7b86fd46a6cb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b54b7d2e-faea-4aa7-ac6d-d393f43a5928", "AQAAAAIAAYagAAAAEMkqxo1VYR5VKvUxFg3P621TDM93Jm60SXB3aO/hBpd4uHhJx8ETdOCPRX9EjhDMuw==", "7daa2c62-f4f8-4e57-a704-5b0c1960079f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePictureUrl",
                table: "Teachers");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f09783ff-02a5-4ee0-87cf-ec2503d36959", "AQAAAAIAAYagAAAAEPzUDTVU06Z636/z5egE0e9bymnN0wRHpHcBYewzYtxVH6AnuwTRmKtM01ekvKe6LA==", "cd3d923d-322e-44d8-bdd2-9e38425afdf8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7672fc12-cc43-4c82-b07b-1fe2928a0bb6", "AQAAAAIAAYagAAAAEFVXex2oHrQVaSGK63X9eTd4lpXAW7dtwXLS4RnYhRVB6NcX5ZHHtoPK6MB9V7NPSA==", "93bd5441-9369-4d7b-b9cc-df69bcce3e3b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de621d1-fd1a-44ec-97c4-d7703ba0740d", "AQAAAAIAAYagAAAAEB4v5CGiNqg8qYdNDChavh9SD/qs+EbebmxSSMtr0hOVDfq1QNbkUqCI7/HJdqMX7w==", "5b4b7bc9-a375-4829-82f2-3d45932ec24f" });
        }
    }
}
