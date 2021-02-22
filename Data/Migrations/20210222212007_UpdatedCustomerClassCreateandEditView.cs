using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class UpdatedCustomerClassCreateandEditView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeeklyPickupDate",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Zip",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "WeeklyPickupDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Customers");

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
    }
}
