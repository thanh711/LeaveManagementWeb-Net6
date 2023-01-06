using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    public partial class AddleaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
