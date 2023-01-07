using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a3e",
                column: "ConcurrencyStamp",
                value: "49736ad3-5cba-4a31-838d-0f19beb9aea5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "819b1183-1e31-4d47-aa51-708962c68a3e",
                column: "ConcurrencyStamp",
                value: "3be16b89-9409-402c-b36f-4db41651835a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a4e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c9e67e6-46eb-4c2a-baf2-20d4461f8890", "AQAAAAEAACcQAAAAEKEFMekJk49NlPOvJ8zlhWS2M/kxfuERbzOEh2ADQzA72oox9iv7YylXGuxO75xLng==", "c58d5572-7f90-423a-a401-9e0aece93d66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a5e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b5dba8e-64e3-4e0c-972e-0b5a75c4a62d", "AQAAAAEAACcQAAAAEL2doQipex+H0qvfeMf/zRHTacbfdnfQClxmONiY0YiNh84+6zxZ+aMtoJ+Edl162w==", "8c60e7b5-c1fc-4ba5-824c-55b7fbfac1bc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a3e",
                column: "ConcurrencyStamp",
                value: "8703169b-d66c-4b5b-af6a-a9dffccbcbd8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "819b1183-1e31-4d47-aa51-708962c68a3e",
                column: "ConcurrencyStamp",
                value: "45672859-5163-477d-9ce8-b279507b9f45");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a4e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1ed77d3-9be2-447a-9e76-149fb103f640", "AQAAAAEAACcQAAAAEMarSZZzuzk3DRbsswVJGG3oADZ1OkkKBoygDjXvcNgiVIbHmzUknMI+gNW0JANrhw==", "90b90fad-6fac-43fc-9d9a-1e00c84a3026" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819b1182-1e31-4d47-aa51-708962c68a5e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5a91918-45f8-4f9c-9282-5843338bc403", "AQAAAAEAACcQAAAAEAZ20Ddz2UtwyyLYMF5s9Qxp2Oy3hmj4tARTFTI++EX2fzNHmaiCrAMW7N3gsZ+6KQ==", "80e838d5-54a8-4fb9-9723-4a95f2c31df1" });
        }
    }
}
