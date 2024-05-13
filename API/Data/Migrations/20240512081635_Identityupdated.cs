using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Identityupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7034696e-bc6f-4111-bef1-d9de2ec650c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2eec83f-1de8-41da-a1a6-d2cc9df9e539");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "339a7e94-d6e0-47b5-8596-d732fac1107f", null, "Admin", "ADMIN" },
                    { "957843e3-67d6-4e2d-9a74-088f0be5c020", null, "Member", "MEMBER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "339a7e94-d6e0-47b5-8596-d732fac1107f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "957843e3-67d6-4e2d-9a74-088f0be5c020");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7034696e-bc6f-4111-bef1-d9de2ec650c2", null, "Member", "MEMBER" },
                    { "d2eec83f-1de8-41da-a1a6-d2cc9df9e539", null, "Admin", "ADMIN" }
                });
        }
    }
}
