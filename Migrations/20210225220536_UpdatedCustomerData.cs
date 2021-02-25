using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class UpdatedCustomerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1236bab1-5ed2-4060-b032-fe8508e1c8f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dd13296-dd3b-4258-b9e0-8411723e7a76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "782932f1-52cd-48a6-93fe-cfd7222eec08");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastCollection",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d32ab490-7c82-435b-98fd-26ba15ef991c", "a98c600d-5e2e-4738-9dd5-c1f495f1b22a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41f24b2d-08b8-4284-98a0-95a50615cb1d", "cae93b2a-99de-4491-80d1-740e9e55724a", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bafe1ed8-d336-4ef8-a402-02571b3d0040", "80204e14-4572-42b6-a9fa-a4421ee6445d", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41f24b2d-08b8-4284-98a0-95a50615cb1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bafe1ed8-d336-4ef8-a402-02571b3d0040");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d32ab490-7c82-435b-98fd-26ba15ef991c");

            migrationBuilder.DropColumn(
                name: "LastCollection",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1236bab1-5ed2-4060-b032-fe8508e1c8f7", "d906515d-c1d5-4daf-a8ba-a2facdf6b7b3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3dd13296-dd3b-4258-b9e0-8411723e7a76", "83a5d5d6-ce9f-40ff-a0a3-fd1893a2cab8", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "782932f1-52cd-48a6-93fe-cfd7222eec08", "dc8bebe3-847f-489e-947f-c06f4aff01f5", "Customer", "CUSTOMER" });
        }
    }
}
