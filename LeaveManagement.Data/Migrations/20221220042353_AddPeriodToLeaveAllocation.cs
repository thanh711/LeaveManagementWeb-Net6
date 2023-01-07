using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    public partial class AddPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a3e",
                column: "ConcurrencyStamp",
                value: "828a41ce-c75f-49de-b968-9f5648ce72cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "819b1183-1e31-4d47-aa51-708962c68a3e",
                column: "ConcurrencyStamp",
                value: "6f93c196-bffc-42cb-80fe-a78624303dd6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a4e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfc32f01-f84c-421e-95dc-b789c6ed8920", "AQAAAAEAACcQAAAAEE99TtTTllkd5b9M7E16QyhIrnYzsnn4I5FMhbF8NAwfpH0nCelyILPp3fys+MYnLA==", "f5fd5a70-9175-4d49-95be-5ae376c1c8c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a5e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55335a29-b6b4-4252-861c-ef33bc3c7b4c", "AQAAAAEAACcQAAAAEF4ChUZ0dw5PTRCWeW9uTx/KNcQHmSezPagYbdOztGYG7v4rUDAliGbuqhpyFTjnuw==", "55aa740d-798f-4935-94e1-fdeefbee3b54" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7b3f15e-3ae4-43e5-b9a9-3b1e0ea9f000", "AQAAAAEAACcQAAAAEF1WhNj4sabhBcgXhTmScK1hwoRQ9j50EVXvjO8CExrf0BzaHj99nBIdIaKSl36Fxw==", "663d9bbd-062f-4292-bf61-a8a18414ca1b" });
        }
    }
}
