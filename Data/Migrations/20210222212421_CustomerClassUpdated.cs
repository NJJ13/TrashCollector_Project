using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class CustomerClassUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a14ea26-36d8-4a6a-bed5-29522dda7d54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8664f9be-94d0-4887-9950-40bbf41d0527");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e1ad83f-fd36-4229-be5a-5fcabe2f7bc1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3206395-e19c-4b2c-a22c-37574a22d82a", "a5f2dcd8-f757-4d2c-902a-2e5e6d2ff364", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7741b67c-df29-41b6-80dd-5447f6cdcf03", "e785f115-6362-4c78-97d2-57dc43aacaa3", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1110e1b5-3aad-4b70-a227-e1483077974b", "03283ca6-f492-422d-afe8-b87c5dc29835", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1110e1b5-3aad-4b70-a227-e1483077974b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7741b67c-df29-41b6-80dd-5447f6cdcf03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3206395-e19c-4b2c-a22c-37574a22d82a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e1ad83f-fd36-4229-be5a-5fcabe2f7bc1", "fbe735c6-348c-49d7-a902-bd566a0e6d66", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a14ea26-36d8-4a6a-bed5-29522dda7d54", "d81058b8-e628-41e2-8386-443108a3fac3", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8664f9be-94d0-4887-9950-40bbf41d0527", "d89515c4-497b-44a6-9cdb-1a3ce5540f38", "Customer", "CUSTOMER" });
        }
    }
}
