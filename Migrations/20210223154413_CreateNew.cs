using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class CreateNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bfc2bba-9799-4a37-b372-5ded308408ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26c73fc4-a98e-4518-b313-16b48c202ad6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e30e9302-a8f3-4045-b7c1-8c71c0f93c59");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf68aebd-8375-490a-853c-43cd390e333f", "247ad241-047f-4d45-84e6-8b37aeb50e39", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a04dc7e-c049-4d67-9bb8-426cfe30bb08", "6f718408-c73e-4051-bd5f-61e70257d775", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d1f8b349-c575-4cc5-915c-beee1fe009ad", "1ba93af1-07bd-4651-9762-86af54b7da19", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a04dc7e-c049-4d67-9bb8-426cfe30bb08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf68aebd-8375-490a-853c-43cd390e333f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1f8b349-c575-4cc5-915c-beee1fe009ad");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1bfc2bba-9799-4a37-b372-5ded308408ea", "90c9f306-656b-4b57-87e1-c35f22c58569", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e30e9302-a8f3-4045-b7c1-8c71c0f93c59", "930260c8-e5c6-4ca1-9141-acf73a1d1869", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26c73fc4-a98e-4518-b313-16b48c202ad6", "12a1b619-c873-4e36-8f12-7ed521a9d572", "Customer", "CUSTOMER" });
        }
    }
}
