using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    public partial class UpdateDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a3e",
                column: "ConcurrencyStamp",
                value: "04ea0a5a-e475-450d-9cb6-033b258126ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "819b1183-1e31-4d47-aa51-708962c68a3e",
                column: "ConcurrencyStamp",
                value: "30bb1d0d-c0e5-4d63-95a1-266e462377dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a4e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52c96bb6-4753-4456-b1a7-25142778c0d9", "AQAAAAEAACcQAAAAECDhWO+z5euQgHmC93HK96upOCQKsPzxFuTmXqbOCo+b6FbFFUWumZ0SUS8WEMp+2g==", "5afafb1e-5aad-4153-acce-a4442bd7f37b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a5e",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7b3f15e-3ae4-43e5-b9a9-3b1e0ea9f000", "THANHS2@USER.COM", "THANHS2@USER.COM", "AQAAAAEAACcQAAAAEF1WhNj4sabhBcgXhTmScK1hwoRQ9j50EVXvjO8CExrf0BzaHj99nBIdIaKSl36Fxw==", "663d9bbd-062f-4292-bf61-a8a18414ca1b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a3e",
                column: "ConcurrencyStamp",
                value: "7401ad22-cf48-4f72-86c9-b63799950b0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "819b1183-1e31-4d47-aa51-708962c68a3e",
                column: "ConcurrencyStamp",
                value: "1141e60e-ec6f-4ea1-bdb6-a7ed1442bc56");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a4e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6949f27a-2252-42b5-a912-2965d9392d9d", "AQAAAAEAACcQAAAAEPauBcCcKGQ2UHSdU4fWhEWbzvIE3SpCiTtZJfheHov9h+uUcOBJpQP/mwzebP+Pig==", "3234d441-1fdb-4c12-9e0e-a7e97741c1d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a5e",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dba649b8-9990-48d0-acf4-59506c5ab006", "THANHS1@USER.COM", "THANHS1@USER.COM", "AQAAAAEAACcQAAAAEM7Q84VkjCOz52Wts69RtqCeQI3zQjJHZkJ0ykFqd1B2Q2hRg7tPLJNdIYLowwRFEA==", "257cfda0-4387-400f-854b-124c8b08e96c" });
        }
    }
}
