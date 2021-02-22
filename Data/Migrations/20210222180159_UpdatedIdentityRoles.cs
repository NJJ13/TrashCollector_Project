using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class UpdatedIdentityRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8235db8e-6004-4f5e-9c1c-09f10896da56");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45de571b-057a-4f50-b6c6-8cf02c7d2d11", "ecd54292-d2d1-44c4-86e0-21af966390ab", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c309d159-88ac-4a2c-a340-da6ac28b53b3", "b1621c06-9846-4592-a3a1-277784e530c6", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "afe7fb33-cee9-4619-822c-ea584fa18fb2", "8ded52d4-2a8d-4aa5-999f-58727de224b0", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45de571b-057a-4f50-b6c6-8cf02c7d2d11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afe7fb33-cee9-4619-822c-ea584fa18fb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c309d159-88ac-4a2c-a340-da6ac28b53b3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8235db8e-6004-4f5e-9c1c-09f10896da56", "e7f53a8b-0e6e-4382-a298-d4c22dabd9e1", "Admin", "ADMIN" });
        }
    }
}
