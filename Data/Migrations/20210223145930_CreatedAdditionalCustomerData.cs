using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class CreatedAdditionalCustomerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "WeeklyPickupDate",
                table: "Customers");

            migrationBuilder.AddColumn<DateTime>(
                name: "AdditionalPickUp",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyDues",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendPickUpEnd",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendPickUpStart",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "WeeklyPickupDay",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5165e92c-f5ac-4b38-a2c3-e626186463a2", "2fbebb96-e443-4e3b-a028-bc7103a058d9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29796800-ce56-4203-8565-20ea4af9f34e", "a2813d9f-4ed2-48b6-a525-353dee85f3d3", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ed38f03-d784-4e44-9893-f0cb086b042e", "9b935099-acfb-4fd0-a67a-795573b6e9e4", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29796800-ce56-4203-8565-20ea4af9f34e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5165e92c-f5ac-4b38-a2c3-e626186463a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ed38f03-d784-4e44-9893-f0cb086b042e");

            migrationBuilder.DropColumn(
                name: "AdditionalPickUp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MonthlyDues",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SuspendPickUpEnd",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SuspendPickUpStart",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "WeeklyPickupDay",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "WeeklyPickupDate",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
